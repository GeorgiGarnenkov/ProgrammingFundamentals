using System;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };
            int dayNum = int.Parse(Console.ReadLine());
            if (dayNum >= 1 && dayNum <= 7)
            {
                Console.WriteLine(days[dayNum - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
            
        }
    }
}
