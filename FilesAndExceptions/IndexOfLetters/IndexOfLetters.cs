namespace IndexOfLetters
{
    using System;
    using System.Collections.Generic;
    using System.IO;


    public class IndexOfLetters
    {
        public static void Main()
        {
            string[] writeWord = { Console.ReadLine() };

            File.WriteAllLines("input.txt", writeWord);
            
            string[] readWord = File.ReadAllLines("input.txt");

            var word = string.Join(string.Empty, readWord).ToCharArray();

            char[] alphabet = new char[26];

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(97 + i);
            }
            
            List<string> print = new List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                var index = Array.IndexOf(alphabet, word[i]);
                print.Add($"{word[i]} -> {index}");
            }

            File.WriteAllLines("output.txt", print);
        }
    }
}
