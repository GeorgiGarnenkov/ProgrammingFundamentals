using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{


    class SoftUniKaraoke
    {
        static void Main()
        {

            var participants = Console.ReadLine().Split(',').Select(c => c.Trim()).ToList();
            var songList = Console.ReadLine().Split(',').Select(c => c.Trim()).ToList();

            Dictionary<string, List<string>> nameAndAward =
                new Dictionary<string, List<string>>();

            foreach (var p in participants)
            {
                nameAndAward[p] = new List<string>();
            }

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "dawn")
                {
                    break;
                }
                
                var commandArgs = line.Split(',').Select(c => c.Trim()).ToList();

                var name = commandArgs[0];
                var song = commandArgs[1];
                var award = commandArgs[2];

                if (participants.Contains(name) && songList.Contains(song))
                {
                    nameAndAward[name].Add(award);
                }
            }
            var result = nameAndAward
                .Select(item => new
                {
                    name = item.Key,
                    awards = item.Value.Distinct().OrderBy(a => a),
                    awardsCount = item.Value.Distinct().Count()
                })
                .OrderByDescending(c => c.awardsCount)
                .ThenBy(c => c.name)
                .Where(c => c.awardsCount > 0)
                .ToArray();

            foreach (var n in result)
            {
                Console.WriteLine($"{n.name}: {n.awardsCount} awards");
                foreach (var aw in n.awards)
                {
                    Console.WriteLine($"--{aw}");
                }
            }
           
            if (result.Length == 0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
