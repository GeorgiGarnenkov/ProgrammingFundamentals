namespace MatchHexadecimalNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class MatchHexadecimalNumbers
    {
        public static void Main()
        {
            var regex = @"\b(0x|)[0-9A-F]{1,}\b";

            var numbersString = Console.ReadLine();

            var numbers = Regex.Matches(numbersString, regex)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
