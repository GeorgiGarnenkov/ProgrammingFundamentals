using System;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            bool result = IsPrime(num);
            Console.WriteLine(result);
        }

        static bool IsPrime(long num)
        {

            bool prime = true;
            if (num < 2)
            {
                return false;

            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
