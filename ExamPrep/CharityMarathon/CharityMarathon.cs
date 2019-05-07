using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            long days = long.Parse(Console.ReadLine());
            long numberOfRunners = long.Parse(Console.ReadLine());
            long avergeNumOfLapPerRunner = long.Parse(Console.ReadLine());
            long trackLength = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal moneyForKilometer = decimal.Parse(Console.ReadLine());

            long totalRunners = trackCapacity * days;
            long totalMeters = 0;
            long totalKm = 0;
            decimal moneyRaised = 0.0m;
            if (totalRunners >= numberOfRunners)
            {
                totalMeters = numberOfRunners * avergeNumOfLapPerRunner * trackLength;
                totalKm = totalMeters / 1000;
                moneyRaised = totalKm * moneyForKilometer;
            }
            else
            {
                totalMeters = totalRunners * avergeNumOfLapPerRunner * trackLength;
                totalKm = totalMeters / 1000;
                moneyRaised = totalKm * moneyForKilometer;
            }
            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
