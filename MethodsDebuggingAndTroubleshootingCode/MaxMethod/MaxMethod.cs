using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = GetMax(a, b, c);
            Console.WriteLine(max);
        }

        static int GetMax(int a, int b, int c)
        {
            var firstNum = Math.Max(a, b);
            var secondNum = Math.Max(firstNum, c);
            return secondNum;
        }
    }
}
