using System.Text;

namespace UnicodeCharacters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = input.Select(t => $@"\u{Convert.ToUInt32(t):x4}").ToList();

            Console.WriteLine(string.Join("", result));


        }
    }
}
