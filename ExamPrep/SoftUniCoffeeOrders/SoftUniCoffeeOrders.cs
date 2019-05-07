using System.Globalization;

namespace SoftUniCoffeeOrders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());   //price = (daysInMonth * capsulesCount) * pricePerCapsule

            decimal totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                decimal price = ReadOrderAndCalculatePrice();
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }

        static decimal ReadOrderAndCalculatePrice()
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());

            string dateStr = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateStr, "d/M/yyyy", CultureInfo.InvariantCulture);
            decimal monthDays = DateTime.DaysInMonth(date.Year, date.Month);
            
            decimal capsulesCount = decimal.Parse(Console.ReadLine());

            decimal price = (monthDays * capsulesCount) * pricePerCapsule;

            Console.WriteLine($"The price for the coffee is: ${price:f2}");

            return price;
        }
    }
}
