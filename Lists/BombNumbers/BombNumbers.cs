using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    public class BombNumbers
    {
        public static void Main()
        {   
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var bombCommand = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
            int bomb = bombCommand[0];
            int power = bombCommand[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int leftPower = Math.Max(i - power, 0);
                    int rightPower = Math.Min(i + power, numbers.Count - 1);

                    numbers.RemoveRange(i, rightPower - i);
                    numbers.RemoveAt(i);
                    numbers.RemoveRange(leftPower, i - leftPower);
                    i = 0;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
