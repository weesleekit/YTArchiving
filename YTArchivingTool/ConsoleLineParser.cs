using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YTArchivingTool
{
    internal static partial class ConsoleLineParser
    {
        // Constants

        private const string downloadStartMessage = "[download]";

        private const string alreadyDownloadedMessage = " has already been recorded in the archive";

        private const string extension = ".f248.webm";

        private const string downloadProgressFragment = "% of ~";

        // Internal Methods

        internal static void ProcessLine(string line, out bool? downloadSkipped, out double? progress, out string? title)
        {
            downloadSkipped = null;
            progress = null;
            title = null;

            if (!line.StartsWith(downloadStartMessage))
            {
                return;
            }

            if (line.EndsWith(alreadyDownloadedMessage))
            {
                downloadSkipped = true;
                return;
            }

            if (line.EndsWith(extension))
            {
                title = GetTitle(line);
            }

            if (line.Contains(downloadProgressFragment))
            {
                progress = GetProgress(line);
            }
        }

        private static string GetTitle(string line)
        {
            string[] split = line.Split('\\');
            string fileNameIncludingDateAndID = split.Last().Replace(extension, string.Empty);

            string[] fileNameSegments = fileNameIncludingDateAndID.Split(' ');
            string date = fileNameSegments[0];
            string id = fileNameSegments[1];

            string title = fileNameIncludingDateAndID.Replace($"{date} {id} ", string.Empty);

            return title;
        }

        private static double? GetProgress(string line)
        {
            Regex regex = PercentageRegexFinder();

            Match match = regex.Match(line);

            if (!match.Success)
            {
                return null;
            }

            string percentageString = match.Groups[1].Value;
            double percentage = double.Parse(percentageString);

            return percentage;
        }


        // Regular expression pattern:
        // (\d+(?:\.\d+)?)%
        // 
        // The pattern consists of the following elements:
        // 1. (\d+(?:\.\d+)?): This is a capturing group, which matches one or more digits, followed by an optional decimal part.
        //    a. \d+: This matches one or more digits (0-9).
        //    b. (?:\.\d+)?: This is a non-capturing group, which matches a decimal point followed by one or more digits. It is optional due to the '?' at the end.
        // 2. %: This matches the percentage sign.
        //
        // The regex pattern will find a sequence of digits, followed by an optional decimal part and a percentage sign, and capture the numeric value in the first capturing group.
        [GeneratedRegex("(\\d+(?:\\.\\d+)?)%")]
        private static partial Regex PercentageRegexFinder();
    }
}
