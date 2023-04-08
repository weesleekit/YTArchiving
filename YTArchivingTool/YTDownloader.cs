using System.Diagnostics;

namespace YTArchivingTool
{
    public class YTDownloader
    {
        // Delegates

        public delegate void DownloadConsoleLineEventHandler(string titleName);

        public delegate void DownloadTitleEventHandler(string titleName);

        public delegate void DownloadProgressEventHandler(double progress);

        public delegate void DownloadFinished();

        public delegate void DownloadSkipped();

        // Events

        public event DownloadTitleEventHandler? DownloadTitleEvent;

        public event DownloadProgressEventHandler? DownloadProgressEvent;

        public event DownloadFinished? DownloadFinishedEvent;

        public event DownloadSkipped? DownloadSkippedEvent;

        public event DownloadConsoleLineEventHandler? DownloadConsoleLine;

        // Fields

        private readonly string binariesPath;

        // Constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="binariesPath">e.g. @"ExternalBinaries\yt-dlp.exe";</param>
        public YTDownloader(string binariesPath)
        {
            this.binariesPath = binariesPath;
        }

        // Public Methods

        /// <summary>
        /// Attempts to download all 1080p vidoes as well as subtitles and thumbnails. Excludes previously downloaded videos (by using a text file archive.txt to track)
        /// </summary>
        /// <param name="url">e.g. "https://www.youtube.com/channel/UC-WpvHaSBQEAztK6n_CupOg"</param>
        /// <param name="folderPath">e.g. @"MyFolder\Brandon Y Lee"</param>
        /// <returns></returns>
        public async Task Download(string url, string folderPath, string basePath)
        {
            string arguments = @$"-S ""res:1080,fps"" -o ""{folderPath}/%(upload_date>%Y-%m-%d)s %(id)s %(title)s.%(ext)s"" --download-archive ""{basePath}/archive.txt"" ""{url}"" --write-auto-sub --write-thumbnail";

            ProcessStartInfo startInfo = new()
            {
                FileName = binariesPath,
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            using Process process = new()
            {
                StartInfo = startInfo,
                EnableRaisingEvents = true,
            };

            process.Exited += Process_Exited;

            process.Start();

            // Capture and process the output in real-time
            var outputTask = Task.Run(async () =>
            {
                using StreamReader reader = process.StandardOutput;
                string line;

                while ((line = await reader.ReadLineAsync()) != null)
                {
                    // Process the output line, e.g., print to console or store it in a variable
                    Console.WriteLine(line);
                    ProcessStandardOutputLine(line);
                }
            });

            var errorTask = Task.Run(async () =>
            {
                using StreamReader reader = process.StandardError;
                string line;

                while ((line = await reader.ReadLineAsync()) != null)
                {
                    // Process the error line, e.g., print to console or store it in a variable
                    Console.WriteLine(line);
                }
            });

            DownloadProgressEvent?.Invoke(0);

            await Task.WhenAll(outputTask, errorTask);

            DownloadFinishedEvent?.Invoke();

            process.WaitForExit();
        }

        // Private Methods

        private void Process_Exited(object sender, EventArgs e)
        {
            Console.WriteLine("The yt-dlp process has finished its work.");
            // Add any additional code to execute after the process has exited
        }

        private void ProcessStandardOutputLine(string line)
        {
            DownloadConsoleLine?.Invoke(line);

            ConsoleLineParser.ProcessLine(line, out bool? downloadSkipped, out double? progress, out string? title);

            if (downloadSkipped != null && (bool)downloadSkipped)
            {
                DownloadSkippedEvent?.Invoke();
            }

            if (progress != null) 
            {
                DownloadProgressEvent?.Invoke((double)progress);
            }

            if (title != null)
            {
                DownloadTitleEvent?.Invoke(title);
            }
        }
    }
}
