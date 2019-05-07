namespace CharacterMultiplier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            string[] line = Console.ReadLine()
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            char[] firstPartChars = line[0].ToCharArray();
            char[] secondPartChars = line[1].ToCharArray();

            List<int> firstNums = new List<int>();
            List<int> secondNums = new List<int>();
            
            for (int i = 0; i < firstPartChars.Length; i++)
            {
                firstNums.Add(firstPartChars[i]);
            }
            for (int i = 0; i < secondPartChars.Length; i++)
            {
                secondNums.Add(secondPartChars[i]);
            }

            if (firstNums.Count == secondNums.Count)
            {
                int sum = 0;

                for (int i = 0; i < firstPartChars.Length; i++)
                {
                    int multiply = firstNums[i] * secondNums[i];
                    sum += multiply;
                }
                Console.WriteLine(sum);
            }

            else
            {
                int sum = 0;

                var minCount = Math.Min(firstNums.Count, secondNums.Count);
                var maxCount = Math.Max(firstNums.Count, secondNums.Count);
                
                for (int i = 0; i < minCount; i++)
                {
                    int multiply = firstNums[i] * secondNums[i];
                    sum += multiply;
                }

                firstNums.RemoveRange(0, minCount);
                secondNums.RemoveRange(0, minCount);

                for (int i = 0; i < maxCount - minCount; i++)
                {
                    if (firstNums.Count != 0 && secondNums.Count == 0)
                    {
                        sum += firstNums[i];
                    }
                    else if (secondNums.Count != 0 && firstNums.Count == 0)
                    {
                        sum += secondNums[i];
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
