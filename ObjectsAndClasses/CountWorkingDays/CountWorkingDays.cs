namespace CountWorkingDays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;


    public class CountWorkingDays
    {
        public static void Main()
        {
            DateTime startDate = DateTime
                .ParseExact(Console.ReadLine(), "dd-MM-yyyy",
                CultureInfo.InvariantCulture);

            DateTime endDate = DateTime
                .ParseExact(Console.ReadLine(), "dd-MM-yyyy",
                CultureInfo.InvariantCulture);

            DateTime[] holidays =
            {
                DateTime
                    .ParseExact("01-01-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("03-03-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("01-05-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("06-05-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("24-05-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("06-09-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("22-09-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("01-11-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("24-12-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("25-12-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("26-12-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture)
            };
            var workingDaysCount = 0;

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
                {
                    bool isHoliday = true;

                    foreach (var holiday in holidays)
                    {
                        if (holiday.Day == i.Day && holiday.Month == i.Month)
                        {
                            isHoliday = false;
                            break;
                        }
                    }
                    if (isHoliday)
                    {
                        workingDaysCount++;
                    }
                }
            }
            Console.WriteLine(workingDaysCount);
        }
    }
}
