using System.Data.Odbc;
using System.Security.Cryptography.X509Certificates;

namespace MinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class MinerTask
    {
        public static void Main()
        {
            Dictionary<string, decimal> mine = new Dictionary<string, decimal>();
            var line = Console.ReadLine();

            while (line != "stop")
            {
                var resources = line;
                var quantity = decimal.Parse(Console.ReadLine());

                if (!mine.ContainsKey(resources))
                {
                    mine[resources] = 0;
                }
                
                mine[resources] += quantity;
                line = Console.ReadLine();
            }
            foreach (var kvp in mine)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
