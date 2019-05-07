using System.IO;

namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            string[] writeNumbers = { Console.ReadLine() };

            File.WriteAllLines("input.txt", writeNumbers);

            string[] readNumber = File.ReadAllLines("input.txt");

            var numbers = string.Join(string.Empty, readNumber)
                .Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

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

            List<string> stringArrayOfNums = new List<string>();
            for (int i = 0; i <= bestLen; i++)
            {
                var nums = int.Parse(numbers[bestStart + i] + " ");
                stringArrayOfNums.AddRange(nums.ToString().Split(' '));
            }

            var print = string.Join(" ", stringArrayOfNums);
            File.WriteAllText("output.txt", print);
        }
    }
}
