using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    public class WinningTicket
    {
        public static void Main()
        {
            string[] tickets = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            char[] symbols = { '@', '#', '$', '^' };

            bool isMatch = false;

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string leftPart = ticket.Substring(0, 10);
                string rightPart = ticket.Substring(10, 10);

                int countLeft = 0;
                int countRight = 0;
                int countTotal = 0;

                string pattern;

                foreach (var symbol in symbols)
                {
                    if (symbol == '^')
                    {
                        pattern = @"[\^]{6,}";
                    }
                    else
                    {
                        pattern = @"[" + symbol + "]{6,}";
                    }
                    countLeft = Regex.Match(leftPart, pattern).Length;
                    countRight = Regex.Match(rightPart, pattern).Length;
                    countTotal = Math.Min(countLeft, countRight);



                    if (Regex.IsMatch(leftPart, pattern) && Regex.IsMatch(rightPart, pattern))
                    {
                        isMatch = true;
                        if (countTotal >= 6 && countTotal <= 9)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {countTotal}{symbol}");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - 10{symbol} Jackpot!");
                        }
                        continue;
                    }
                }
                if (isMatch == false)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
                isMatch = false;
            }
        }
    }
}