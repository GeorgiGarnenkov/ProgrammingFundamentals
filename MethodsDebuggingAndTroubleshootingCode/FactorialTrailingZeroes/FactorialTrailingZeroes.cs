using System;
using System.Numerics;
namespace FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger result = CalcFactorial(n);
            Console.WriteLine(CalculateTrailingZeroes(result));
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

        static int CalculateTrailingZeroes(BigInteger n)
        {
            int zeroesCounter = 0;

            while (n % 10 == 0)
            {
                zeroesCounter++;
                n /= 10;
            }
            return zeroesCounter;
        }
    }
}
