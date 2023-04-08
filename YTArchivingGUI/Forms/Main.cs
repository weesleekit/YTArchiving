using YTArchivingGUI.Classes;
using YTArchivingGUI.Models;
using YTArchivingTool;

namespace YTArchivingGUI.Forms
{
    public partial class Main : Form
    {
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

            try
            {
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

                if (!configuration.Any())
                {
                    return;
                }

                treeViewFoldersAndSubs.ExpandAll();

                treeViewFoldersAndSubs.Nodes[0].EnsureVisible();
            }
            finally
            {
                disableCheckEvent = false;
            }
        }

        private async Task StartDownload(Dictionary<Subscription, SubFolder> toDownload)
        {
            string basePath = textBoxOutputPath.Text;

            Downloader downloader = new(basePath);

            Hide();
            downloader.Show(this);
            await downloader.StartDownloads(toDownload);
            Show();
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
            Dictionary<Subscription, SubFolder> toDownload = new();

            foreach (var subFolder in configuration)
            {
                foreach (var subscription in subFolder.Subscriptions)
                {
                    if (!subscription.Active)
                    {
                        continue;
                    }

                    toDownload.Add(subscription, subFolder);
                }
            }

            await StartDownload(toDownload);
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
                Dictionary<Subscription, SubFolder> toDownload = new()
                {
                    { subscription, subParent }
                };
                await StartDownload(toDownload);
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

            configuration = PresetConfiguration.Configuration.OrderBy(x => x.Name).ToList();
            foreach (var subfolder in configuration)
            {
                subfolder.Subscriptions = subfolder.Subscriptions.OrderBy(x => x.Name).ToList();
            }
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