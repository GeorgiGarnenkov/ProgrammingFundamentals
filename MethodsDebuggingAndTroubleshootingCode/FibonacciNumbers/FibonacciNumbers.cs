using System;

namespace FibonacciNumbers
{
    class Program
    {
        public static int FibonacciNumber(int n)
        {
            int a = 1;
            int b = 1;
            for (int i = 1; i <= n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNumber(n));

        }
    }
}
