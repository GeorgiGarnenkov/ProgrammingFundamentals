namespace MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class MagicExchangeableWords
    {
        public static void Main()
        {
            string[] line = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            char[] firstPartChars = line[0].ToCharArray().Distinct().ToArray();
            char[] secondPartChars = line[1].ToCharArray().Distinct().ToArray();

            if (firstPartChars.Length == secondPartChars.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
