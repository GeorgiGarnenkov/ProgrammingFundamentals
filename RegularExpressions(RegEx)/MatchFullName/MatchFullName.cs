namespace MatchFullName
{
    using System;
    using System.Text.RegularExpressions;


    public class MatchFullName
    {
        public static void Main()
        {
            string regex = @"\b[A-Z][a-z]+ \b[A-Z][a-z]+";

            string names = Console.ReadLine();

            if (names != null)
            {
                MatchCollection matchedName = Regex.Matches(input: names, pattern: regex);

                foreach (Match name in matchedName)
                {
                    Console.Write(name.Value + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
