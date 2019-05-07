using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {
            var textWords = Console.ReadLine()
                .ToLower()
                .Split('.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ')
                .ToArray();

            var result = textWords.Where(x => x != "").Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Distinct();

            Console.WriteLine(String.Join(", ", result));
        }
    }
}
