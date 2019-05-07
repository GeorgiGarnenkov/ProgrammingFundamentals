using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class KeyReplacer
    {
        public static void Main()
        {

            string[] keyWords = Console.ReadLine()
                .Split(new char[] {'|', '<', '\\'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string sentencesLine = Console.ReadLine();

            Regex regex = new Regex($"({keyWords[0]})(.*?)({keyWords[2]})");

            MatchCollection match = regex.Matches(sentencesLine);
            List<string> newWords = new List<string>();
            foreach (var words in match)
            {
                newWords.Add(words.ToString()
                    .Replace($"{keyWords[0]}", "")
                    .Replace($"{keyWords[2]}", ""));
                if (newWords.Contains(""))
                {
                    newWords.RemoveRange(0, newWords.Count);
                }
            }
            if (newWords.Count > 0)
            {
                Console.WriteLine(string.Concat(newWords));
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
