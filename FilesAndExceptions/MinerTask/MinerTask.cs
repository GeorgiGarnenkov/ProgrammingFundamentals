namespace MinerTask
{
    using System;
    using System.Collections.Generic;
    using System.IO;


    public class MinerTask
    {
        public static void Main()
        {
            var resources = AvalableResources();
            ResourcesWriteToFile(resources);
        }

        public static void ResourcesWriteToFile(Dictionary<string, long> resources)
        {
            string result = null;
            foreach (var resource in resources)
                result += $"{resource.Key} -> {resource.Value}{Environment.NewLine}";

            File.WriteAllText("output.txt", result);
        }

        public static Dictionary<string, long> AvalableResources()
        {
            var data = File.ReadAllLines("input.txt");

            var resources = new Dictionary<string, long>();

            var resourceName = data[0];
            resources[resourceName] = 0;

            for (var i = 1; i < data.Length; i++)
            {
                if (data[i] == "stop")
                    break;
                if (i % 2 == 0)
                {
                    resourceName = data[i];
                    if (!resources.ContainsKey(resourceName))
                        resources[resourceName] = 0;
                }
                else
                {
                    resources[resourceName] += long.Parse(data[i]);
                }
            }

            return resources;
        }
    }
}
