using System.Linq;

namespace MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;


    public class MatchPhoneNumber
    {
        public static void Main()
        {
            

            string phones = Console.ReadLine();

            var regex = @"\+359 2 \d{3} \d{4}\b|\+359-2-\d{3}-\d{4}\b";

            var result = Regex.Matches(phones, regex);

            var matchedPhones = result
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));


        }
    }
}
