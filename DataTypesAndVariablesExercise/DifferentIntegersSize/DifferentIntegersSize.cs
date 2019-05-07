using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

                if (number <= long.MaxValue)
                {
                    Console.WriteLine($"{number} can fit in:");
                    if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                    {
                        Console.WriteLine("* sbyte");
                    }
                    if (number >= byte.MinValue && number <= byte.MaxValue)
                    {
                        Console.WriteLine("* byte");
                    }
                    if (number >= short.MinValue && number <= short.MaxValue)
                    {
                        Console.WriteLine("* short");
                    }
                    if (number >= ushort.MinValue && number <= ushort.MaxValue)
                    {
                        Console.WriteLine("* ushort");
                    }
                    if (number >= int.MinValue && number <= int.MaxValue)
                    {
                        Console.WriteLine("* int");
                    }
                    if (number >= uint.MinValue && number <= uint.MaxValue)
                    {
                        Console.WriteLine("* uint");
                    }
                    if (number >= long.MinValue && number <= long.MaxValue)
                    {
                        Console.WriteLine("* long");
                    }
                }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}
