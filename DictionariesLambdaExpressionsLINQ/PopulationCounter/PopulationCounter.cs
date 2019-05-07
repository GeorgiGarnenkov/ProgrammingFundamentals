using System.Security.Cryptography.X509Certificates;

namespace PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class PopulationCounter
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> countries =
                new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] commandArgs = input.Split('|');

                string country = commandArgs[1];
                string city = commandArgs[0];
                long population = long.Parse(commandArgs[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                    countries[country].Add(city, population);
                }
                else
                {
                    if (!countries[country].ContainsKey(city))
                    {
                        countries[country].Add(city, population);
                    }
                }
                
                input = Console.ReadLine();
            }
            foreach (var country in countries.OrderByDescending(p => p.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
