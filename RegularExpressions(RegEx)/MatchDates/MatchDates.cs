using System.Text.RegularExpressions;

namespace MatchDates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class MatchDates
    {
        public static void Main()
        {
            var regex = @"\b(\d{2})([\/\-\.])([A-Z][a-z]{2})\2(\d{4})\b";

            var dateString = Console.ReadLine();

            var datesMatches = Regex.Matches(dateString, regex);

            foreach (Match date in datesMatches)
            {
                var day = date.Groups[1].Value;
                var month = date.Groups[3].Value;
                var year = date.Groups[4].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

            }

        }
    }
}
