namespace LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class LogsAggregator
    {
        public static void Main()
        {
            SortedDictionary<string, SortedDictionary<string, int>> users =
                new SortedDictionary<string, SortedDictionary<string, int>>();

            string input = Console.ReadLine();

            for (int i = 0; i < int.Parse(input); i++)
            {
                string[] commandArgs = Console.ReadLine().Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                string name = commandArgs[1];
                string ip = commandArgs[0];
                int duration = int.Parse(commandArgs[2]);

                if (!users.ContainsKey(name))
                {
                    users.Add(name, new SortedDictionary<string, int>());
                }
                if (!users[name].ContainsKey(ip))
                {
                    users[name].Add(ip, 0);
                }

                users[name][ip] += duration;
            }

            foreach (var name in users)
            {
                Console.WriteLine($"{name.Key}: {name.Value.Values.Sum()} " +
                                  $"[{string.Join(", ", name.Value.Keys)}]");
            }
        }
    }
}
