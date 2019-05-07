using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());

            string hex = digit.ToString("X");
            string binary = Convert.ToString(digit, 2);

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
