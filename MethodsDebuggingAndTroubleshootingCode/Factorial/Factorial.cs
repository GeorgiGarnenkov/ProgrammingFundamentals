using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(CalcFactorial(n));
        }

        static BigInteger CalcFactorial(BigInteger n)
        {
            BigInteger sum = 1;
            for (BigInteger i = n; i >= 1; i--)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
