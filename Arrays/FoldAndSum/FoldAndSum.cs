using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = array.Length / 4;

            int[] leftArray = array.Take(k).ToArray();
            int[] middleArray = array.Skip(k).Take(k * 2).ToArray();
            int[] rightArray = array.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);
                                           // !!! Ако искаме да залепим масивите след ревърса може да използваме и : 
                                           // int[] somеthing = leftArray.Concat(rightArray).ToArray();
            int[] result = new int[k * 2];
            for (int i = 0; i < k; i++)         
            {
                result[i] = middleArray[i] + leftArray[i];
                result[i + k] = middleArray[i + k] + rightArray[i];
            }
            Console.WriteLine($"{string.Join(" ", result)}");
        }
    }
}
