namespace MultiplyBigNumber
{
    using System;
    using System.Linq;
    using System.Text;

    class MultiplyBigNumber
    {
        static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (first == "0" || second == "0" || first == "")
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();
            var sum = 0;
            var number = 0;
            var reminder = 0;

            for (int i = first.Length - 1; i >= 0; i--)
            {
                sum = (first[i] - 48) * int.Parse(second) + reminder;
                number = sum % 10;
                sb.Append(number);
                reminder = sum / 10;
                
                if (i == 0 && reminder > 0)
                {
                    sb.Append(reminder);
                }
            }

            Console.WriteLine(new string(sb.ToString()
                .TrimEnd('0')
                .ToCharArray()
                .Reverse()
                .ToArray()));
        }
    }
}
