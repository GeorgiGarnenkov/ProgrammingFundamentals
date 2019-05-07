using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayStrings
{
    class ReverseArrayStrings
    {
        static void Main()
        {
            var readString = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var reversed = readString.Reverse();
            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
