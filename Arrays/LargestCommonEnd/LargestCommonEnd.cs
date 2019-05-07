using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main()
        {
            //         var first = Console.ReadLine()
            //             .Split(' ')
            //             .ToArray();
            //         var second = Console.ReadLine()
            //             .Split(' ')
            //             .ToArray();
            //         
            //         var counter = 0;
            //         
            //         int length = Math.Min(first.Length, second.Length);
            //         
            //         var lengthLeft = 0;
            //         var lengthRight = 0;
            //         
            //         for (int i = 0; i < length; i++)
            //         {
            //             if (first[i] == second[i])
            //             {
            //                 lengthLeft++;
            //             }
            //             if (first[first.Length - 1 - i] == second[second.Length - 1 - i])
            //             {
            //                 lengthRight++;
            //             }
            //         
            //         }
            //         if (lengthLeft >= lengthRight)
            //         {
            //             Console.WriteLine(lengthLeft);
            //         }
            //         else
            //         {
            //             Console.WriteLine(lengthRight);
            //         }
                       
            //  ---------------------------- SECOND SOLUTION !!! -------------------------- //

            string[] firstArr = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int leftCount = FindCommonItems(firstArr, secondArr);
            Array.Reverse(firstArr);
            secondArr = secondArr.Reverse().ToArray();
            int rightCount = FindCommonItems(firstArr, secondArr);

            Console.WriteLine($"{Math.Max(leftCount, rightCount)}");
        }

        static int FindCommonItems(string[] firstArr, string[] secondArr)
        {
            int length = Math.Min(firstArr.Length, secondArr.Length);
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }
    }
}
