namespace MostFrequentNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Text;
    

    public class MostFrequentNumber
    {
        public static void Main()
        {
            string[] writeNumbers = {Console.ReadLine()};
            File.WriteAllLines("input.txt", writeNumbers);

            string[] readNums = File.ReadAllText("input.txt" ).Split(new char[] {' '}
            ,StringSplitOptions.RemoveEmptyEntries);

            var groups = readNums.GroupBy(x => x);
            var largest = groups.OrderByDescending(x => x.Count()).First();
            
            File.WriteAllText("output.txt", largest.Key);
        }
    }
}
