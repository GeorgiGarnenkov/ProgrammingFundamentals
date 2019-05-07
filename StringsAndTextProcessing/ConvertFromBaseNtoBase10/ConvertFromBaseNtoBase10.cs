

namespace ConvertFromBaseNtoBase10
{
    using System;
    using System.Numerics;

    public class ConvertFromBaseNtoBase10
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Trim().Split();

            int baseNum = int.Parse(input[0]);

            char[] numberOfBase = input[1].ToCharArray();

            BigInteger result = new BigInteger(0);

            for (int i = 0; i < numberOfBase.Length; i++)
            {
                int reminder = (int)Char.GetNumericValue(numberOfBase[i]);

                result += reminder * BigInteger.Pow(baseNum, numberOfBase.Length - i - 1);
            }

            Console.WriteLine(result);
        }
    }
}
