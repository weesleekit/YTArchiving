namespace YTArchiving
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<string> channels = new()
            {
                "3blue1brown", // Education - Maths
                "brandonylee", // Education - Cameras & Lighting
            };

            foreach (string channel in channels)
            {
                await PlayListDownloader.Download(channel);
            }
        }
    }
}
