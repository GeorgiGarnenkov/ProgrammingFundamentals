using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class OddOccurrences
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var words = input.ToLower().Split(' ');

            var count = new Dictionary<string, int>();
            foreach (var word in words)
            {
                count[word]++;
            }
            foreach (var word in words)
            {
                count[word] = 0;
            }

            List<string> result = new List<string>();
            foreach (var item in count)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
