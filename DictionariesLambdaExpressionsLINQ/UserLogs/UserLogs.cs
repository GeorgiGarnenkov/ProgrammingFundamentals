namespace UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class UserLogs
    {
        public static void Main()
        {
            var users = new SortedDictionary<string, Dictionary<string, int>>();  // user -> IP -> count

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] commandArgs = line.Split(' ');

                string name = commandArgs[2].Replace("user=", "");
                string ip = commandArgs[0].Replace("IP=", "");

                if (!users.ContainsKey(name))
                {
                    users.Add(name, new Dictionary<string, int>());
                }
                if (!users[name].ContainsKey(ip))
                {
                    users[name].Add(ip, 0);
                }
                users[name][ip] = users[name][ip] + 1;

            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}: ");

                int counter = 0;

                foreach (var ipAndCount in user.Value)
                {
                    Console.Write($"{ipAndCount.Key} => {ipAndCount.Value}");
                    if (counter < user.Value.Count - 1)
                    {
                        Console.Write(", ");
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine(".");
                    }
                }
            }
        }
    }
}
