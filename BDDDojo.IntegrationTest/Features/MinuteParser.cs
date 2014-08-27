using System.Text.RegularExpressions;

namespace Rain.BDDDojo.IntegrationTest.Features
{
    public class MinuteParser
    {
        public static int Parse(string duration)
        {
            Match match = Regex.Match(duration, @"(\d+)\s?minute(s)?");
            if (match.Success)
            {
                string minText = match.Groups[1].Value;
                return int.Parse(minText);
            }

            return 0;
        }
    }
}