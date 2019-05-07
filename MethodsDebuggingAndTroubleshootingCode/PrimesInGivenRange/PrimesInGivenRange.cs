using System;
using System.Collections.Generic;
using System.Dynamic;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());

            List<int> primes = FindPrimesInRange(startNum, endNum);

            Console.Write(string.Join(", ", primes));
            Console.WriteLine();
        }

        public static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            
            List<int> primeNumbers = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                bool prime = IsPrime(i);
                if (prime)
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers;
        }

        public static bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}
