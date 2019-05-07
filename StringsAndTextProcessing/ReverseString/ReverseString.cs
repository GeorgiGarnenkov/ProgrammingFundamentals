namespace ReverseString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class ReverseString
    {
        public static void Main()
        {
            string sample = Console.ReadLine();

            char[] sampleChars = sample
                .ToCharArray()
                .Reverse()
                .ToArray();

            Console.WriteLine(sampleChars);
        }
    }
}
