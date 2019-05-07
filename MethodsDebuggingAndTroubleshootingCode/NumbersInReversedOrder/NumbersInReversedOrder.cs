using System;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main()
        {
            string num = Console.ReadLine();
            string reverse = ReversedTheNumberOrder(num);
            Console.WriteLine(reverse);
        }

        static string ReversedTheNumberOrder(string num)
        {
            string result = "";
            for (int i = num.Length - 1; i >= 0; i--)
            {
                result += num[i];
            }
            return result;
        }
    }
}
