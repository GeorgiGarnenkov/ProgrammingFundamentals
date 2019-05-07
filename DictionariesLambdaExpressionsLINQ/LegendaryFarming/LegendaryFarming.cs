namespace LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class LegendaryFarming
    {
        public static void Main()
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();

            var legendaryItems = new Dictionary<string, int>();

            legendaryItems.Add("shards", 250);

            legendaryItems.Add("fragments", 250);

            legendaryItems.Add("motes", 250);

            bool input = true;

            while (input == true)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                
                for (int i = 0; i < commandArgs.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        int quantity = int.Parse(commandArgs[i]);
                        string material = commandArgs[i + 1].ToLower();
                        if (!materials.ContainsKey(material))
                        {
                            materials.Add(material, quantity);
                        }
                        else
                        {
                            materials[material] += quantity;
                        }
                    }

                    
                    if (!(materials.ContainsKey("fragments")))
                    {
                        materials.Add("fragments", 0);
                    }
                    if (!(materials.ContainsKey("shards")))
                    {
                        materials.Add("shards", 0);
                    }
                    if (!(materials.ContainsKey("motes")))
                    {
                        materials.Add("motes", 0);
                    }

                    
                    foreach (var material in materials)
                    {
                        foreach (var item in legendaryItems)
                        {
                            if (material.Key == item.Key && material.Value >= item.Value)
                            {
                                materials[material.Key] -= 250;

                                if (item.Key == "shards")
                                {
                                    Console.WriteLine("Shadowmourne obtained!");
                                    foreach (var mat in materials
                                        .OrderByDescending(s => s.Value).ThenBy(s => s.Key))
                                    {
                                        if (mat.Key == "shards" || mat.Key == "fragments" 
                                            || mat.Key == "motes")
                                        {
                                            Console.WriteLine($"{mat.Key}: {mat.Value}");
                                        }
                                    }
                                    foreach (var junks in materials.OrderBy(s => s.Key))
                                    {
                                        if (junks.Key != "shards" && junks.Key != "fragments"
                                            && junks.Key != "motes")
                                        {
                                            Console.WriteLine($"{junks.Key}: {junks.Value}");
                                        }
                                    }
                                    return;
                                }

                                
                                else if (item.Key == "fragments")
                                {
                                    Console.WriteLine("Valanyr obtained!");
                                    foreach (var mat in materials
                                        .OrderByDescending(s => s.Value).ThenBy(s => s.Key))
                                    {
                                        if (mat.Key == "shards" || mat.Key == "fragments"
                                            || mat.Key == "motes")
                                        {
                                            Console.WriteLine($"{mat.Key}: {mat.Value}");
                                        }
                                    }
                                    foreach (var junks in materials.OrderBy(s => s.Key))
                                    {
                                        if (junks.Key != "shards" && junks.Key != "fragments"
                                            && junks.Key != "motes")
                                        {
                                            Console.WriteLine($"{junks.Key}: {junks.Value}");
                                        }
                                    }
                                    return;
                                }

                                
                                else if (item.Key == "motes")
                                {
                                    Console.WriteLine("Dragonwrath obtained!");
                                    foreach (var mat in materials
                                        .OrderByDescending(s => s.Value).ThenBy(s => s.Key))
                                    {
                                        if (mat.Key == "shards" || mat.Key == "fragments" 
                                            || mat.Key == "motes")
                                        {
                                            Console.WriteLine($"{mat.Key}: {mat.Value}");
                                        }
                                    }
                                    foreach (var junks in materials.OrderBy(s => s.Key))
                                    {
                                        if (junks.Key != "shards" && junks.Key != "fragments"
                                            && junks.Key != "motes")
                                        {
                                            Console.WriteLine($"{junks.Key}: {junks.Value}");
                                        }
                                    }
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
