using System.ComponentModel.Design;

namespace SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Sales
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public static Sales ReadSales()
        {

            string[] input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Sales sale = new Sales()
            {
                Town = input[0],
                Product = input[1],
                Price = int.Parse(input[2]),
                Quantity = int.Parse(input[3]),
            };

            return sale;
        }

        public static Sales[] ReadSaleses()
        {
            int n = int.Parse(Console.ReadLine());

            Sales[] saleses = new Sales[n];

            for (int i = 0; i < n; i++)
            {
                saleses[i] = ReadSales();
            }
            return saleses;
        }

    }
    

    public class SalesReport
    {
        public static void Main()
        {
            Sales[] s = Sales.ReadSaleses();





        }
    }

}