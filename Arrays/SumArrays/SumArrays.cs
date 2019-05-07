using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class SumArrays
    {
        static void Main()
        {
            var arr1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var arr2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            if (arr1.Length <= arr2.Length)
            {
                var arrMax = arr2.Length;
                for (int i = 0; i < arr2.Length; i++)
                {
                    arrMax = (arr1[i % arr1.Length] + arr2[i % arr2.Length]);
                    if (i >= arr2.Length)
                    {
                        break;
                    }
                    Console.WriteLine(arrMax + " ");
                }
            }
            else
            {
                var arrMax = arr1.Length;
                for (int i = 0; i < arr1.Length; i++)
                {
                    arrMax = (arr1[i % arr1.Length] + arr2[i % arr2.Length]);
                    if (i >= arr1.Length)
                    {
                        break;
                    }
                    Console.WriteLine(arrMax + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
