using System;

namespace EnglishNameOfLastDigit
{
    class EnglishNameOfLastDigit
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(ReturnNameOfTheLastDigit(n));
        }
        static string ReturnNameOfTheLastDigit(long number)
        {
            if (Math.Abs(number % 10) == 1)
            {
                return "one";
            }
            else if (Math.Abs(number % 10) == 2)
            {
                return "two";
            }
            else if (Math.Abs(number % 10) == 3)
            {
                return "three";
            }
            else if (Math.Abs(number % 10) == 4)
            {
                return "four";
            }
            else if (Math.Abs(number % 10) == 5)
            {
                return "five";
            }
            else if (Math.Abs(number % 10) == 6)
            {
                return "six";
            }
            else if (Math.Abs(number % 10) == 7)
            {
                return "seven";
            }
            else if (Math.Abs(number % 10) == 8)
            {
                return "eight";
            }
            else if (Math.Abs(number % 10) == 9)
            {
                return "nine";
            }
            else
            {
                return "zero";
            }
        }
    }
}
