using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CubicMessages
{
    public class CubicMessages
    {
        public static void Main()
        {
            var pattern = @"^(?<leftPart>\d+)(?<message>[A-Za-z]+)(?<rightPart>[^A-Za-z]*)$";

            var messageRegex = new Regex(pattern);

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Over!")
                {
                    break;
                }

                var messageMatch = messageRegex.Match(input);
                if (!messageMatch.Success)
                {
                    continue;
                }
                var leftPart = messageMatch.Groups["leftPart"].Value;
                var message = messageMatch.Groups["message"].Value;
                var rightPart = messageMatch.Groups["rightPart"].Value;

                var messageLength = int.Parse(Console.ReadLine());

                if (messageLength != message.Length)
                {
                    continue;
                }


                //var verificationCode = (leftPart + rightPart) 
                //    .Where(char.IsDigit)
                //    .Select(@char => int.Parse(@char.ToString()))
                //    .Select(index => index >= 0 && index < messageLength ? message[index] : ' ')
                //    .ToArray();       
                //                                 |
                //           това или следващото \\ //
                //                                 |
                var verificationCode = new StringBuilder();
                foreach (var @char in leftPart + rightPart)
                {
                    if (!char.IsDigit(@char))
                    {
                        continue;
                    }
                    var index = int.Parse(@char.ToString());

                    var isValidIndex = index >= 0 && index < messageLength;

                    if (isValidIndex)
                    {
                        verificationCode.Append(message[index]);
                    }
                    else
                    {
                        verificationCode.Append(' ');
                    }
                }

                Console.WriteLine($"{message} == {verificationCode}");
            }
        }
    }
}
