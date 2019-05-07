using System.Globalization;

namespace DayOfWeek
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DayOfWeek
    {
        public static void Main()
        {
            string stringDate = Console.ReadLine();

            DateTime day = DateTime.ParseExact(stringDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(day.DayOfWeek);
        }
    }
}