using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    public class SumReversedNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine();

            var newNumbers = ReverseString(string.Join(" ", numbers))
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var sum = 0;

            for (int i = 0; i < newNumbers.Count; i++)
            {
                sum = sum + newNumbers[i];
            }
            Console.WriteLine(sum);
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
