using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float time = (float)(hours + minutes / 60.0 + seconds / 3600.0);

            
            float kmInHours = (float)((distanceInMeters /1000.0)/time);
            float metersInSeconds = (float)(kmInHours / 3.6);
            float milesInHours = (distanceInMeters / 1609.0f)/ time;

            Console.WriteLine($"{metersInSeconds}");
            Console.WriteLine($"{kmInHours}");
            Console.WriteLine($"{milesInHours}");

        }
    }
}
