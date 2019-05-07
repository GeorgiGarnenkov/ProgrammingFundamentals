
using System.Text.RegularExpressions;

namespace Roli_TheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class RoliTheCoder
    {
        public static void Main()
        {
            SortedDictionary<int, SortedDictionary<string, List<string>>> dictEvent =
                new SortedDictionary<int, SortedDictionary<string, List<string>>>();

            string input;
            while ((input = Console.ReadLine()) != "Time for Code")
            {
                string[] commandArgs = input
                    .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int id = int.Parse(commandArgs[0]);
                string group = commandArgs[1];

                var patternForGroup = @"#[A-Za-z0-9]+";
                if (group[0] == '#' && Regex.IsMatch(group, patternForGroup))
                {
                    if (!dictEvent.ContainsKey(id))
                    {
                        dictEvent.Add(id, new SortedDictionary<string, List<string>>());
                        dictEvent[id].Add(group, new List<string>());
                    }

                    if (dictEvent[id].ContainsKey(group))
                    {
                        var patternForPlayer = @"@[A-Za-z0-9\'\-]+";
                        for (int i = 2; i < commandArgs.Length; i++)
                        {
                            var player = commandArgs[i];
                            if (player[0] == '@' 
                                && Regex.IsMatch(player,patternForPlayer) 
                                && !dictEvent[id][group].Contains(player))
                            {
                                dictEvent[id][group].Add(player);
                            }
                        }
                    }
                }
            }
            foreach (var id in dictEvent.OrderByDescending(x => x.Value.Values.Sum(y => y.Count)))
            {
                List<string> participants = new List<string>();
                foreach (var meet in id.Value)
                {
                    participants = meet.Value.Distinct().ToList();
                    participants.Sort();

                    int count = participants.Count;
                    var meetName = meet.Key.TrimStart('#');

                    Console.WriteLine($"{meetName} - {count}");
                }
                foreach (var name in participants.OrderBy(a => a))
                {
                    Console.WriteLine($"{name}");
                }
            }
        }
    }
}
