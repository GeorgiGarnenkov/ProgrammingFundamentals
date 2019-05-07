namespace RandomizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RandomizeWords
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var rnd = new Random();

            for (int i = 0; i < text.Length; i++)
            {
                int index = rnd.Next(text.Length);
                int newIndex = rnd.Next(text.Length);
                string rem = text[index];
                text[index] = text[newIndex];
                text[newIndex] = rem;
            }
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
