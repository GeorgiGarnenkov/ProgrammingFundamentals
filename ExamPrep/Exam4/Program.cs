using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Exam4
{
    public class Data
    {
        public string Set { get; set; }

        public string Key { get; set; }

        public int Size { get; set; }

    }

    public class Program
    {
        public static void Main()
        {

            List<Data> data= new List<Data>();

            List<string> cache = new List<string>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "thetinggoesskrra")
                {
                    break;
                }
                var commandArgs = command
                    .Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs.Length == 1)
                {
                    var set = commandArgs[0];
                    cache.Add(set);
                }

                if (commandArgs.Length == 3)
                {
                    var set = commandArgs[2];
                    var key = commandArgs[0];
                    var size = int.Parse(commandArgs[1]);
                    
                    Data dataa = new Data();

                    dataa.Set = set;
                    dataa.Key = key;
                    dataa.Size = size;

                    data.Add(dataa);
                }
            }




            

            Console.WriteLine();
        }
    }
}
