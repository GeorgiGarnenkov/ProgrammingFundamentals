using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    public class EnduranceRally
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var zones = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();
            var checkpoints = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            
            for (int n = 0; n < names.Length; n++)
            {
                var fuelByName = (decimal) names[n].First();

                for (int z = 0; z < zones.Length; z++)
                {
                    if (checkpoints.Contains(z))
                    {
                        fuelByName += zones[z];
                    }
                    else
                    {
                        fuelByName -= zones[z];
                    }
                    if (fuelByName <= 0)
                    {
                        Console.WriteLine($"{names[n]} - reached {z}");
                        break;
                    }
                }
                if (fuelByName > 0)
                {
                    Console.WriteLine($"{names[n]} - fuel left {fuelByName:f2}");
                }
            }
        }
    }
}
