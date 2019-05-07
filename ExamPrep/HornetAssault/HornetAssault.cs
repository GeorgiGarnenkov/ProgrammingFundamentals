using System.Diagnostics;

namespace HornetAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class HornetAssault
    {
        public static void Main()
        {
            List<long> bees = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();
            List<long> hornets = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            List<long> aliveBees = new List<long>();

            foreach (var beehive in bees)
            {
                if (hornets.Count == 0)
                {
                    aliveBees.Add(beehive);
                    continue;
                }

                var sumPowerOfHornets = hornets.Sum();

                if (sumPowerOfHornets >= beehive)
                {
                    if (sumPowerOfHornets == beehive)
                    {
                        hornets.RemoveAt(0);
                    }
                }
                else
                {
                    aliveBees.Add(beehive - sumPowerOfHornets);
                    hornets.RemoveAt(0);
                }
            }
            if (aliveBees.Count != 0)
            {
                Console.WriteLine(string.Join(" ", aliveBees));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
