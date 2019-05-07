using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    public class ChangeList
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var command = Console.ReadLine();
            
            while (!(command == "Odd" && command == "Even"))
            {
                var commandArgs = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (commandArgs[0] == "Delete")
                {
                    if (numbers.Contains(int.Parse(commandArgs[1])))
                    {
                        numbers.RemoveAll(x => x == (int.Parse(commandArgs[1])));
                    }
                }
                else if (commandArgs[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commandArgs[2]), int.Parse(commandArgs[1]));
                }
                else if (commandArgs[0] == "Odd")
                {
                    numbers.RemoveAll(x => x % 2 == 0);
                    break;

                }
                else if (commandArgs[0] == "Even")
                {
                    numbers.RemoveAll(x => x % 2 != 0);
                    break;
                }
                command = Console.ReadLine();
            } 
            Console.WriteLine($"{string.Join(" ", numbers)}");
        }
    }
}
