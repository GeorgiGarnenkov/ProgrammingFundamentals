namespace AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> ShopList { get; set; }

        public decimal Bill { get; set; }
    }

    public class AndreyAndBilliard
    {
        public static void Main()
        {
            Dictionary<string, decimal> productsPrices = new Dictionary<string, decimal>();
            int productCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < productCount; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string nameProduct = input[0];
                decimal priceProduct = decimal.Parse(input[1]);

                if (!productsPrices.ContainsKey(nameProduct))
                {
                    productsPrices.Add(nameProduct, priceProduct);
                }
                productsPrices[nameProduct] = priceProduct;
            }

            string inputLine = Console.ReadLine();
            List<Customer> customers = new List<Customer>();
            while (inputLine != "end of clients")
            {
                string[] customerInfo = inputLine.Split(',', '-');

                string customerName = customerInfo[0];
                string customerProduct = customerInfo[1];
                int productQuantity = int.Parse(customerInfo[2]);
                if (!productsPrices.ContainsKey(customerProduct))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }
                if (customers.Any(c => c.Name == customerName))
                {
                    Customer customer = customers.First(c => c.Name == customerName);
                    if (!customer.ShopList.ContainsKey(customerProduct))
                    {
                        customer.ShopList.Add(customerProduct, productQuantity);
                    }
                    else
                    {
                        customer.ShopList[customerProduct] += productQuantity;
                    }
                    customer.Bill += productQuantity * productsPrices[customerProduct];
                }
                else
                {
                    Customer customer = new Customer();
                    customer.Name = customerName;
                    customer.ShopList = new Dictionary<string, int>();
                    customer.ShopList.Add(customerProduct, productQuantity);
                    customer.Bill += productQuantity * productsPrices[customerProduct];
                    customers.Add(customer);
                }
                inputLine = Console.ReadLine();
            }

            foreach (Customer customer in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, int> customerOrders in customer.ShopList)
                {
                    Console.WriteLine($"-- {customerOrders.Key} - {customerOrders.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }
            decimal totalBill = customers.Sum(c => c.Bill);
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}
