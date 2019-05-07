using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartOfTheASCIITable
{
    class PrintPartOfTheASCIITable
    {
        static void Main(string[] args)
        {
            short num1 = short.Parse(Console.ReadLine());
            short num2 = short.Parse(Console.ReadLine());

            for (int symbolNum = num1; symbolNum <= num2; symbolNum++)
            {
                char value = (char)symbolNum;
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }
}
