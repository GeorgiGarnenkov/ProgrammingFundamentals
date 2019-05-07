namespace CameraView
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Linq;

    public class CameraView
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int skipNums = nums[0];
            int takeNums = nums[1];

            string pattern = "\\|<(\\w{" + skipNums + "})(\\w{0," + takeNums + "})";

            string input = Console.ReadLine();

            MatchCollection matchedResult = Regex.Matches(input, pattern);

            List<string> res = new List<string>();
            foreach (Match m in matchedResult)
            {
                res.Add(m.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ", res));

        }
    }
}
