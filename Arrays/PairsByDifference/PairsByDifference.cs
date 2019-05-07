using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    public class PairsByDifference
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int maxNum = Math.Max(numbers[i], numbers[j]);
                    int minNum = Math.Min(numbers[i], numbers[j]);
                    int sum = maxNum - minNum;

                    if (sum == difference)
                    {
                        counter++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(counter);
            }
        }
    }
}
