using YTArchivingGUI.Models;
using YTArchivingTool;

namespace YTArchivingGUI.Forms
{
    public partial class Downloader : Form
    {
        // Constants

        private const int maxBufferLength = 50000;
        private const string binariesPath = @"ExternalBinaries\yt-dlp.exe";

        // Fields

        private int skipCount = 0;
        private int downloadCount = 0;
        private readonly string basePath;

        // Constructor

        public Downloader(string basePath)
        {
            InitializeComponent();
            this.basePath = basePath;
        }

        // Public Methods


        internal async Task StartDownloads(Dictionary<Subscription, SubFolder> toDownload)
        {
            skipCount = 0;
            downloadCount = 0;

            textBoxTitles.Text = string.Empty;

            foreach (var item in toDownload)
            {
                await StartDownload(item.Key, item.Value);
            }

            textBoxTitles.Text += $"{Environment.NewLine}Finished";
        }

        private async Task StartDownload(Subscription subscription, SubFolder subFolder)
        {
            // TODO:Disable interface, enable cancel button

            string localPath = $@"{subFolder.Name}\{subscription.Name}";

            string fullPath = Path.Join(basePath, localPath);

            YTDownloader yTDownloader = new(binariesPath);

            yTDownloader.DownloadFinishedEvent += DownloadFinishedEvent;
            yTDownloader.DownloadProgressEvent += YTDownloader_DownloadProgressEvent;
            yTDownloader.DownloadTitleEvent += YTDownloader_DownloadTitleEvent;
            yTDownloader.DownloadConsoleLine += YTDownloader_DownloadConsoleLine;
            yTDownloader.DownloadSkippedEvent += YTDownloader_DownloadSkippedEvent;

            await yTDownloader.Download(subscription.URL, fullPath, basePath);

            progressBarDownload.Value = 100;
        }

        private void YTDownloader_DownloadConsoleLine(string line)
        {
            Invoke(() =>
            {
                AppendTextToTextBox(line);
            });
        }

        private void AppendTextToTextBox(string text)
        {
            if (textBoxConsole.InvokeRequired)
            {
                textBoxConsole.Invoke(new Action<string>(AppendTextToTextBox), text);
                return;
            }

            if (textBoxConsole.TextLength + text.Length > maxBufferLength)
            {
                int excessLength = (textBoxConsole.TextLength + text.Length) - maxBufferLength;
                textBoxConsole.Text = textBoxConsole.Text[excessLength..];
            }

            textBoxConsole.AppendText($"{Environment.NewLine}{text}");
            textBoxConsole.SelectionStart = textBoxConsole.TextLength;
            textBoxConsole.ScrollToCaret();
        }


        private void YTDownloader_DownloadTitleEvent(string titleNameIncludingDate)
        {
            Invoke(() =>
            {
                textBoxTitles.Text += $"{Environment.NewLine}{titleNameIncludingDate}";
                textBoxTitles.SelectionStart = textBoxTitles.TextLength;
                textBoxTitles.ScrollToCaret();

                downloadCount++;
                UpdateCounterLabel();
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
                UpdateCounterLabel();
            });
        }

        private void YTDownloader_DownloadSkippedEvent()
        {
            Invoke(() =>
            {
                skipCount++;
                UpdateCounterLabel();
            });
        }

        private void UpdateCounterLabel()
        {
            labelSkipped.Text = $"{skipCount} skipped, {downloadCount} downloaded";
        }
    }
}
