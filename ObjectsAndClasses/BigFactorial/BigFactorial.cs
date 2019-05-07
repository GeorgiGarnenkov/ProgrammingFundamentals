namespace BigFactorial
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger sum = 1;
            for (BigInteger i = n; i >= 1; i--)
            {
                sum *= i;
            }
            Console.WriteLine(sum);

        }
    }
}
