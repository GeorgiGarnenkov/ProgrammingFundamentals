using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbersAwayFromZero
{
    class RoundingNumbersAwayFromZero
    {
        static void Main()
        {
            double[] arr = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            int[] roundedNumbers = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                roundedNumbers[i] = (int)Math.Round(arr[i],
                    MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} -> {roundedNumbers[i]}");
            }
        }
    }
}
