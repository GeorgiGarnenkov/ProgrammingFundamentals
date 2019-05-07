using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main()
        {
            var time = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            var stepsToHome = long.Parse(Console.ReadLine());
            var secForStep = long.Parse(Console.ReadLine());

            long seconds = time[2] + 60 * time[1] + 60 * 60 * time[0];

            var secondsToAdd = stepsToHome * secForStep;

            seconds = seconds + secondsToAdd;

            var secs = seconds % 60;
            var mins = (seconds / 60) % 60;
            var hours = (seconds / 60 / 60) % 24;

            Console.WriteLine($"Time Arrival: {hours:d2}:{mins:d2}:{secs:d2}");



        }
    }
}
