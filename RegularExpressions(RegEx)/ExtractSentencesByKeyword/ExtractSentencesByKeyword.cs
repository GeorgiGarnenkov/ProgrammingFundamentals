using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;


    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            string word = Console.ReadLine();

            string[] sentences = Console.ReadLine()
                .Split(new char[] {'.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"\b" + word + @"\b";

            Regex regex = new Regex(pattern);

            foreach (var sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
