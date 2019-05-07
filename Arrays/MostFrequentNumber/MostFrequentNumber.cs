using System;
using System.Linq;

namespace MostFrequentNumber
{
    public class MostFrequentNumber
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var groups = numbers.GroupBy(x => x);
            var largest = groups.OrderByDescending(x => x.Count()).First();

            Console.WriteLine(largest.Key);
        }
    }
}
