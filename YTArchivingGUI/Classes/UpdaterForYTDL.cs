using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YTArchivingGUI.Classes
{
    internal static class UpdaterForYTDL
    {



        //https://ffbinaries.com/api/v1/version/latest

        internal static async Task<string> GetRemoteVersion()
        {
            string releaseUrl = "https://github.com/yt-dlp/yt-dlp/releases/latest/";

            try
            {
                using HttpClient client = new();
                HttpResponseMessage response = await client.GetAsync(releaseUrl);
                response.EnsureSuccessStatusCode(); // Ensure a successful response (status code 2xx).

                // If you need to handle the HTML document, you can access it using response.Content.
                string htmlContent = await response.Content.ReadAsStringAsync();


            }
            catch (HttpRequestException ex)
            {
                if (ex.StatusCode == null)
                {
                    Console.WriteLine("An error occurred while retrieving the latest yt-dlp version data.");
                    return null;
                }

                if (ex.StatusCode != System.Net.HttpStatusCode.Redirect)
                {
                    Console.WriteLine("Did not get redirect for the latest version link. Status: " + ex.StatusCode);
                    return null;
                }

                //string directUrl = ex.Headers.Location.OriginalString;
                //string versionRegex = Regex.Match(directUrl, @"[0-9]+\.[0-9]+\.[0-9]+").Value;
                //return versionRegex != string.Empty ? versionRegex : null;
            }

            return null;
        }
    }
}
