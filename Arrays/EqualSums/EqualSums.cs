using System;
using System.Linq;

namespace EqualSums
{
    public class EqualSums
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool isFindEqualSum = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    Console.WriteLine(i);
                    isFindEqualSum = true;
                    break;
                }
            }
            if (!isFindEqualSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
