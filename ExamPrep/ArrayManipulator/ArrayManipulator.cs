using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main()
        {
            int[] arrNums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                var commandArgs = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var mainCommand = commandArgs[0];
                if (mainCommand == "exchange")
                {
                    var index = int.Parse(commandArgs[1]);

                    arrNums = ExchangeElements(arrNums, index);

                }
                else if (mainCommand == "max" || mainCommand == "min")
                {
                    var evenOrOdd = commandArgs[1];

                    IndexOfMinOrMaxEvenOrOddElement(arrNums, mainCommand, evenOrOdd);
                }
                else if (mainCommand == "first" || mainCommand == "last")
                {
                    var count = int.Parse(commandArgs[1]);
                    var evenOrOdd = commandArgs[2];

                    FindFirstOrLastEvenOrOddElements(arrNums, mainCommand, count, evenOrOdd);
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", arrNums));
        }

        static void FindFirstOrLastEvenOrOddElements(int[] arrNums, string maincommand, int count, string evenOrOdd)
        {
            if (count > arrNums.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            var parity = evenOrOdd == "even" ? 0 : 1;

            var evenOrOddElements = arrNums
                .Where(a => a % 2 == parity)
                .ToArray();

            var firstOrLastEvenOrOddElements = new List<int>();
            if (maincommand == "first")
            {
                firstOrLastEvenOrOddElements.AddRange(evenOrOddElements.Take(count));
            }
            else
            {
                firstOrLastEvenOrOddElements.AddRange(evenOrOddElements.Skip(evenOrOddElements.Length - count));
            }
            Console.WriteLine("[{0}]", string.Join(", ", firstOrLastEvenOrOddElements));
        }


        static void IndexOfMinOrMaxEvenOrOddElement(int[] arrNums, string mainCommand, string evenOrOdd)
        {
            var parity = evenOrOdd == "even" ? 0 : 1;

            var evenOrOddElements = arrNums
                .Where(a => a % 2 == parity)
                .ToArray();
            if (evenOrOddElements.Length == 0)
            {
                Console.WriteLine("No matches");
                return;
            }
            int minOrMaxElement;
            if (mainCommand == "min")
            {
                minOrMaxElement = evenOrOddElements.Min();
            }
            else
            {
                minOrMaxElement = evenOrOddElements.Max();
            }
            var index = Array.LastIndexOf(arrNums, minOrMaxElement);
            Console.WriteLine(index);
        }

        static int[] ExchangeElements(int[] arrNums, int index)
        {
            var isValidIndex = index >= 0 && index < arrNums.Length;
            if (!isValidIndex)
            {
                Console.WriteLine("Invalid index");
                return arrNums;
            }

            var oldArr = arrNums.Take(index + 1).ToArray();
            var newArr = arrNums.Skip(index + 1).ToArray();
            var result = newArr.Concat(oldArr).ToArray();

            return result;
        }
    }
}
