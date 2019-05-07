namespace MatchNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;


    public class MatchNumbers
    {
        public static void Main()
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var numbersString = Console.ReadLine();

            var numbers = Regex.Matches(numbersString, regex);

            foreach (Match num in numbers)
            {
                Console.Write(num.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
