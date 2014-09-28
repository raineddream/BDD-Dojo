using System.Text.RegularExpressions;

namespace Rain.BDDDojo.IntegrationTest.Features
{
    public class MinuteParser
    {
        private const int MinutesPerHour = 60;
        private const int MinutesPerDay  = 24 * MinutesPerHour;
        private const int MinutesPerWeek = 7 * MinutesPerDay;

        public static int Parse(string duration)
        {
            int totalMinutes = 0;

            totalMinutes += ParseWeeks(duration) * MinutesPerWeek;
            totalMinutes += ParseDays(duration) * MinutesPerDay;
            totalMinutes += ParseHours(duration) * MinutesPerHour;
            totalMinutes += ParseMinutes(duration);

            return totalMinutes;
        }

        private static int ParseWeeks(string duration)
        {
            return ParseNumberAccordingToPattern(@"(\d+)\s?week(s)?", duration);
        }

        private static int ParseDays(string duration)
        {
            return ParseNumberAccordingToPattern(@"(\d+)\s?day(s)?", duration);
        }

        private static int ParseHours(string duration)
        {
            Match match = Regex.Match(duration, @"(\d+)\s?hour(s)?");
            if (match.Success)
            {
                string minText = match.Groups[1].Value;
                return int.Parse(minText);
            }

            return 0;
        }

        private static int ParseMinutes(string duration)
        {
            Match match = Regex.Match(duration, @"(\d+)\s?minute(s)?");
            if (match.Success)
            {
                string minText = match.Groups[1].Value;
                return int.Parse(minText);
            }

            return 0;
        }

        private static int ParseNumberAccordingToPattern(string dayPattern, string duration)
        {
            Match match = Regex.Match(duration, dayPattern);
            if (match.Success)
            {
                string minText = match.Groups[1].Value;
                return int.Parse(minText);
            }

            return 0;
        }
    }
}