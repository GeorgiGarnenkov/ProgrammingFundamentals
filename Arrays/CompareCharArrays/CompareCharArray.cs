using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    public class CompareCharArray
    {
        public static void Main()
        {
            char[] first = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            char[] second = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            int length = Math.Min(first.Length, second.Length);

            bool isFirst = false;

            for (int i = 0; i < length; i++)
            {
                var firstIndex = (int) first[i];
                var secondIndex = (int)second[i];

                if (firstIndex <= secondIndex)
                {
                    isFirst = true;
                }
                else
                {
                    break;
                }
            }
            if (isFirst == true && length == first.Length)
            {
                Console.WriteLine(string.Join("", first));
                Console.WriteLine(string.Join("", second));
            }
            else
            {
                Console.WriteLine(string.Join("", second));
                Console.WriteLine(string.Join("", first));
            }
        }
    }
}