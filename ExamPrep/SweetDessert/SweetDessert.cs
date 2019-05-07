using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class SweetDessert
    {
        static void Main()
        {
            double cash = double.Parse(Console.ReadLine());
            double numOfGuests = double.Parse(Console.ReadLine());
            double priceOfBanana = double.Parse(Console.ReadLine());
            double priceOfEggs = double.Parse(Console.ReadLine());
            double priceOfBerries = double.Parse(Console.ReadLine());

            var setsOfPortions = Math.Ceiling(numOfGuests / 6);

            var neededMoney = setsOfPortions * (2 * priceOfBanana)
                              + setsOfPortions * (4 * priceOfEggs)
                              + setsOfPortions * (0.2 * priceOfBerries);
            if (neededMoney <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(neededMoney - cash):f2}lv more.");
            }
        }
    }
}
