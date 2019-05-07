namespace PokemonDontGo
{
    using System;
    using System.Linq;
    using System.Numerics;


    public class PokemonDontGo
    {
        public static void Main()
        {
            var sequence = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            long removedNums = 0;

            bool isTrue = true;
            while (isTrue)
            {
                var index = int.Parse(Console.ReadLine());

                long numberOfIndex = 0;

                if (index < 0)
                {
                    numberOfIndex = sequence[0];
                    sequence.RemoveAt(0);
                    sequence.Insert(0, sequence.Last());
                    for (var i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] <= numberOfIndex)
                        {
                            sequence[i] += numberOfIndex;
                        }
                        else if (sequence[i] > numberOfIndex)
                        {
                            sequence[i] -= numberOfIndex;
                        }
                    }
                }
                else if (index > sequence.Count - 1)
                {
                    numberOfIndex = sequence[sequence.Count - 1];
                    sequence.RemoveAt(sequence.Count - 1);
                    sequence.Add(sequence[0]);
                    for (var i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] <= numberOfIndex)
                        {
                            sequence[i] += numberOfIndex;
                        }
                        else if (sequence[i] > numberOfIndex)
                        {
                            sequence[i] -= numberOfIndex;
                        }
                    }
                }
                else if (index >= 0)
                {
                    numberOfIndex = sequence[index];
                    sequence.RemoveAt(index);
                    for (var i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] <= numberOfIndex)
                        {
                            sequence[i] += numberOfIndex;
                        }
                        else if (sequence[i] > numberOfIndex)
                        {
                            sequence[i] -= numberOfIndex;
                        }
                    }
                }
                removedNums += numberOfIndex;

                if (sequence.Count <= 0)
                {
                    isTrue = false;
                }
            }
            Console.WriteLine(removedNums);
        }
    }
}
