namespace TextFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class TextFilter
    {
        public static void Main()
        {
            string[] banWords = Console.ReadLine()
                .Split(new char[] {',', ' '},StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string text = Console.ReadLine();

            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord,new string('*', banWord.Length));
                }
            }
            Console.WriteLine(text);

        }
    }
}
