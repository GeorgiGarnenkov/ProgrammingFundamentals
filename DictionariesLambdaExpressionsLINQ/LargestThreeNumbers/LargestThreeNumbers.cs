using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestThreeNumbers
{
    public class LargestThreeNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            if (numbers.Length >= 3)
            {
                numbers = numbers.OrderByDescending(x => x).Take(3).ToArray();
            }
            else
            {
                numbers = numbers.OrderByDescending(x => x).ToArray();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
