using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers.RemoveAll(i => i < 0);
            numbers.Reverse();

           var emptyList = new List<int>(numbers.Count);

            foreach (var num in numbers)
            {
                if (num == 0)
                {
                    Console.WriteLine("empty");
                }
                else
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    return;
                }
            }
            
        }
    }
}
