using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main()
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int takeMiddleElement = arr.Length / 2;

            if (arr.Length == 1)
            {
                Console.WriteLine($"{{ {arr[0]} }}");
            }
            else if (arr.Length % 2 == 0)
            {
                Console.WriteLine($"{{ {arr[takeMiddleElement - 1]}, {arr[takeMiddleElement]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {arr[takeMiddleElement - 1]}, " +
                                  $"{arr[takeMiddleElement]}, " +
                                  $"{arr[takeMiddleElement + 1]} }}");
            }
        }
    }
}
