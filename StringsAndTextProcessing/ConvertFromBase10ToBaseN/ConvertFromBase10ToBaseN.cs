namespace ConvertFromBase10ToBaseN
{
    using System;
    using System.Numerics;
    using System.Linq;


    public class ConvertFromBase10ToBaseN
    {
        public static void Main()
        {
            BigInteger[] nums = Console.ReadLine()
                .Split(' ')
                .Select(BigInteger.Parse)
                .ToArray();
            BigInteger baseNum = nums[0];
            BigInteger number = nums[1];

            BigInteger remainder = 0;

            string result = string.Empty;
            while (number > 0)
            {
                remainder = number % baseNum;

                number /= baseNum;

                result = remainder.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}
