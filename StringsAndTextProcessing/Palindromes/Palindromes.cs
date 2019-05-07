using System.Text;

namespace Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(new[] { ' ', ',', '?', '!', '.', ':', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)
                .Distinct()
                .ToArray();

            List<string> result = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                string reversedText = ReverseString(text[i]);
                if (text[i] == reversedText)
                {
                    result.Add(reversedText);
                }
            }
            Console.WriteLine(string.Join(", ", result).TrimEnd());
        }

        public static string ReverseString(string text)
        {
            StringBuilder sb = new StringBuilder(text.Length);

            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }
    }
}
