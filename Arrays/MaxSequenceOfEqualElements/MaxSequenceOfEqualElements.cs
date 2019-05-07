using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()                                 // 2 1 1 2 3 3 2 2 2 1|| 2 2 2
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)// 1 1 1 2 3 1 3 3    || 1 1 1
                .Select(int.Parse)                                             // 4 4 4 4            || 4 4 4 4
                .ToArray();                                                    // 0 1 1 5 2 2 6 3 3  || 1 1
            int start = 0;
            int bestStart = 0;
            int len = 0;
            int bestLen = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[start] == numbers[i])
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                }
                else
                {
                    start++;
                    i = start;
                    len = 0;
                }
            }
            for (int i = 0; i <= bestLen; i++)
            {
                Console.Write(numbers[bestStart + i] + " ");
            }
            Console.WriteLine();
        }
    }
}
