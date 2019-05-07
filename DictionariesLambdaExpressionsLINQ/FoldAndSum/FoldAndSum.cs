using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var k = numbers.Length / 4;

            int[] leftSide = numbers.Take(k).Reverse().ToArray();
            int[] rightSide = numbers.Reverse().Take(k).ToArray();

            int[] row1 = leftSide.Concat(rightSide).ToArray();
            int[] row2 = numbers.Skip(k).Take(2 * k).ToArray();

            var sum = row1.Select((x, i) => x + row2[i]);
            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
