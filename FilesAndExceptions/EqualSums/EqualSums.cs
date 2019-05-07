namespace EqualSums
{
    using System;
    using System.Linq;
    using System.IO;


    public class EqualSums
    {
        public static void Main()
        {
            string[] writeNumbers = { Console.ReadLine() };

            File.WriteAllLines("input.txt", writeNumbers);

            string[] readNumber = File.ReadAllLines("input.txt");

            var numbers = string.Join(string.Empty, readNumber)
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            
            bool isFindEqualSum = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    File.WriteAllText("output.txt", i.ToString());
                    isFindEqualSum = true;
                    break;
                }
            }
            if (!isFindEqualSum)
            {
                File.WriteAllText("output.txt", "no");
            }
        }
    }
}
