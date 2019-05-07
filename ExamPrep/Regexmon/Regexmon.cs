namespace Regexmon
{
    using System;
    using System.Text.RegularExpressions;

    public class Regexmon
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern1 = @"[^A-Za-z-]+";
            string pattern2 = @"[A-Za-z]+-[A-Za-z]+";

            Regex regexDidi = new Regex(pattern1);
            Regex regexBojo = new Regex(pattern2);

            while (true)
            {
                Match didiMatch = regexDidi.Match(input);
                if (didiMatch.Success)
                {
                    Console.WriteLine(didiMatch.Value.ToString());
                }
                else
                {
                    return;
                }

                int firstSymbolDidi = didiMatch.Index;
                input = input.Substring(firstSymbolDidi + didiMatch.Length);

                Match bojoMatch = regexBojo.Match(input);
                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch.Value.ToString());
                }
                else
                {
                    return;
                }

                int firstSymbolBojo = bojoMatch.Index;
                input = input.Substring(firstSymbolBojo + bojoMatch.Length);
            }
        }
    }
}
