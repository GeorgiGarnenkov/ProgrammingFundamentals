using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeCheckerRefactor
{
    class FastPrimeCheckerRefactor
    {
        static void Main(string[] args)
        {
            int givenNumber = int.Parse(Console.ReadLine());
            for (int i = 2; i <= givenNumber; i++)
            {
                bool newNumber = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        newNumber = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {newNumber}");
            }

        }
    }
}
