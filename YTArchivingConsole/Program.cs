using YTArchivingTool;

namespace YTArchivingConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string binariesPath = @"ExternalBinaries\yt-dlp.exe";
            string url = "https://www.youtube.com/channel/UC-WpvHaSBQEAztK6n_CupOg";
            string path = @"MyFolder\Brandon Y Lee";

            YTDownloader yTDownloader = new(binariesPath);

            await yTDownloader.Download(url, path);
        }
    }
}
