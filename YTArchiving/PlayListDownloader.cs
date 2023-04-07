using System.Diagnostics;

namespace YTArchiving
{
    internal static class PlayListDownloader
    {
        internal async static Task Download(string id)
        {
            string exePath = @"ExternalBinaries\yt-dlp.exe";

            string arguments = @$"-S ""res:1080,fps"" -o ""{id}/%(upload_date>%Y-%m-%d)s %(id)s %(title)s.%(ext)s"" --download-archive archive.txt ""https://www.youtube.com/@{id}"" --write-auto-sub --write-thumbnail";

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = exePath,
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            using Process process = new Process
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

            await Task.WhenAll(outputTask, errorTask);

            process.WaitForExit();
        }

        private static void Process_Exited(object sender, EventArgs e)
        {
            Console.WriteLine("The yt-dlp process has finished its work.");
            // Add any additional code to execute after the process has exited
        }
    }
}
