using System;
using System.Linq;
using System.Xml.Linq;
using YTArchivingGUI.Classes;
using YTArchivingGUI.Models;
using YTArchivingTool;

namespace YTArchivingGUI.Forms
{
    public partial class Main : Form
    {
        // Constants

        private const string binariesPath = @"ExternalBinaries\yt-dlp.exe";

        // Fields

        private List<SubFolder> configuration = new();

        private bool disableCheckEvent = false;

        // Constructor

        public Main()
        {
            InitializeComponent();

            configuration = LoadSaveManager.Load();

            UpdateTree();
        }


        // Public Methods

        internal void NewFolder(string name)
        {
            SubFolder subFolder = new SubFolder()
            {
                Name = name
            };

            configuration.Add(subFolder);
            configuration = configuration.OrderBy(x => x.Name).ToList();

            LoadSaveManager.Save(configuration);
            UpdateTree();
        }

        internal void NewSubscription(string name, string url, SubFolder subFolder)
        {
            Subscription subscription = new Subscription()
            {
                Name = name,
                URL = url,
            };

            subFolder.Subscriptions.Add(subscription);
            subFolder.Subscriptions = subFolder.Subscriptions.OrderBy(x => x.Name).ToList();

            LoadSaveManager.Save(configuration);
            UpdateTree();
        }

        // Private Methods

        private void UpdateTree()
        {
            disableCheckEvent = true;

            treeViewFoldersAndSubs.Nodes.Clear();

            foreach (var folder in configuration)
            {
                var newFolderNode = treeViewFoldersAndSubs.Nodes.Add(folder.Name);
                newFolderNode.Tag = folder;

                if (folder.Subscriptions == null)
                {
                    continue;
                }

                foreach (var subscription in folder.Subscriptions)
                {
                    var newSubscriptionNode = newFolderNode.Nodes.Add(subscription.Name);
                    newSubscriptionNode.Tag = subscription;
                    newSubscriptionNode.Checked = subscription.Active;
                }
            }

            treeViewFoldersAndSubs.ExpandAll();

            treeViewFoldersAndSubs.Nodes[0].EnsureVisible();

            disableCheckEvent = false;
        }

        private async Task StartDownload(Subscription subscription, SubFolder subFolder)
        {
            // TODO:Disable interface, enable cancel button

            string basePath = textBoxOutputPath.Text;

            string localPath = $@"{subFolder.Name}\{subscription.Name}";

            string fullPath = Path.Join(basePath, localPath);

            YTDownloader yTDownloader = new(binariesPath);

            yTDownloader.DownloadFinishedEvent += DownloadFinishedEvent;
            yTDownloader.DownloadProgressEvent += YTDownloader_DownloadProgressEvent;
            yTDownloader.DownloadTitleEvent += YTDownloader_DownloadTitleEvent;
            yTDownloader.DownloadConsoleLine += YTDownloader_DownloadConsoleLine;
            yTDownloader.DownloadSkippedEvent += YTDownloader_DownloadSkippedEvent;
            skipped = 0;

            listBoxTitles.Items.Clear();

            await yTDownloader.Download(subscription.URL, fullPath, basePath);
        }

        private void YTDownloader_DownloadConsoleLine(string line)
        {
            Invoke(() =>
            {
                if (textBoxConsole.Text.Length == 0)
                {
                    textBoxConsole.Text += $"{line}";
                }
                else
                {
                    textBoxConsole.Text += $"{Environment.NewLine}{line}";
                }
            });
        }

        private void YTDownloader_DownloadTitleEvent(string titleName)
        {
            Invoke(() =>
            {
                listBoxTitles.Items.Add(titleName);
            });
        }

        private void YTDownloader_DownloadProgressEvent(double progress)
        {
            Invoke(() =>
            {
                progressBarDownload.Value = (int)(progress);
            });
        }

        private void DownloadFinishedEvent()
        {
            Invoke(() =>
            {
                progressBarDownload.Value = 100;
                listBoxTitles.Items.Add("Finished");
            });
        }

        int skipped = 0;

        private void YTDownloader_DownloadSkippedEvent()
        {
            Invoke(() =>
            {
                skipped++;
                labelSkipped.Text = $"{skipped} skipped";
            });
        }

        // UI Events

        private void ButtonNewFolder_Click(object sender, EventArgs e)
        {
            Hide();
            NewFolder newFolder = new(this);
            newFolder.ShowDialog(this);
        }

        private void ButtonNewSub_Click(object sender, EventArgs e)
        {
            var node = treeViewFoldersAndSubs.SelectedNode;

            if (node == null)
            {
                return;
            }

            if (node.Tag is not SubFolder)
            {
                return;
            }

            SubFolder subFolder = (SubFolder)node.Tag;

            Hide();
            NewSubscription newSubscription = new(this, subFolder);
            newSubscription.ShowDialog(this);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var node = treeViewFoldersAndSubs.SelectedNode;

            if (node == null)
            {
                return;
            }

            if (node.Tag is SubFolder subFolder)
            {
                var answer = MessageBox.Show($"Are you sure you want to delete {subFolder.Name}?", "Careful!", MessageBoxButtons.YesNo);

                if (answer == DialogResult.No)
                {
                    return;
                }

                configuration.Remove(subFolder);
            }
            else if (node.Tag is Subscription subscription)
            {
                var answer = MessageBox.Show($"Are you sure you want to delete {subscription.Name}?", "Careful!", MessageBoxButtons.YesNo);

                if (answer == DialogResult.No)
                {
                    return;
                }

                SubFolder subParent = (SubFolder)node.Parent.Tag;

                subParent.Subscriptions.Remove(subscription);
            }
            else
            {
                return;
            }

            LoadSaveManager.Save(configuration);
            UpdateTree();
        }

        private async void ButtonSyncAll_Click(object sender, EventArgs e)
        {
            foreach (var subFolder in configuration)
            {
                foreach (var subscription in subFolder.Subscriptions)
                {
                    if (!subscription.Active)
                    {
                        continue;
                    }

                    await StartDownload(subscription, subFolder);
                }
            }
        }

        private async void ButtonSyncSelected_Click(object sender, EventArgs e)
        {
            var node = treeViewFoldersAndSubs.SelectedNode;

            if (node == null)
            {
                return;
            }

            if (node.Tag is SubFolder)
            {
                return;
            }
            else if (node.Tag is Subscription subscription)
            {
                if (!subscription.Active)
                {
                    var answer = MessageBox.Show($"{subscription.Name} is not currently active (ticked), are you sure you want to download it?", "Subscription not active", MessageBoxButtons.YesNo);

                    if (answer == DialogResult.No)
                    {
                        return;
                    }
                }

                SubFolder subParent = (SubFolder)node.Parent.Tag;

                await StartDownload(subscription, subParent);
            }
            else
            {
                return;
            }
        }

        private void ButtonLoadPreset_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("This will erase your existing configuration, are you sure?", "Careful!", MessageBoxButtons.YesNo);

            if (answer == DialogResult.No)
            {
                return;
            }

            configuration = PresetConfiguration.Configuration;
            LoadSaveManager.Save(configuration);
            UpdateTree();
        }

        private void TreeViewFoldersAndSubs_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (disableCheckEvent)
            {
                return;
            }

            try
            {
                disableCheckEvent = true;

                if (e.Node == null)
                {
                    return;
                }

                if (e.Node.Tag is SubFolder subFolder)
                {
                    e.Node.Checked = false;
                    return;
                }
                else if (e.Node.Tag is Subscription subscription)
                {
                    subscription.Active = e.Node.Checked;
                }
                else
                {
                    return;
                }

                LoadSaveManager.Save(configuration);
            }
            finally
            {
                disableCheckEvent = false;
            }
        }

        private void buttonBrowseOutputPath_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}