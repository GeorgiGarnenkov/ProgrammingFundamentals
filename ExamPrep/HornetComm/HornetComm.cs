namespace HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class Messages
    {
        public string Digits { get; set; }

        public string DigitsLetters { get; set; }

    }

    public class Broadcasts
    {
        public string NoDigits { get; set; }

        public string DigitsLetters { get; set; }
    }


    public class HornetComm
    {
        public static void Main()
        {
            Regex ToUpeerMatches = new Regex("[A-Z]");
            Regex ToLowerMatches = new Regex("[a-z]");
            Regex noLettersAndNoDigits = new Regex("\\W");
            Regex wordsLettersAndDigitsMatch = new Regex("[a-zA-Z0-9]+");
            Regex allDigitMatch = new Regex("\\d+");
            Regex anythingButDigits = new Regex("\\D+");

            List<Broadcasts> broadcasts = new List<Broadcasts>();
            List<Messages> messages = new List<Messages>();


            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Hornet is Green")
                {
                    break;
                }
                string[] commandArgs = input
                    .Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs.Length != 2)
                {
                    continue;
                }

                Broadcasts matchesB = new Broadcasts();
                Messages matchesM = new Messages();
                if (allDigitMatch.IsMatch(commandArgs[0])
                    && wordsLettersAndDigitsMatch.IsMatch(commandArgs[1])
                    && !noLettersAndNoDigits.IsMatch(commandArgs[1]))
                {
                    matchesM.Digits = commandArgs[0];
                    matchesM.DigitsLetters = commandArgs[1];

                    messages.Add(matchesM);
                }
                else if (anythingButDigits.IsMatch(commandArgs[0])
                         && wordsLettersAndDigitsMatch.IsMatch(commandArgs[1]))
                {
                    if (anythingButDigits.IsMatch(commandArgs[1]))
                    {
                        var charsOfTheCommand = commandArgs[1].ToCharArray();
                        for (int i = 0; i < charsOfTheCommand.Length; i++)
                        {
                            if (ToUpeerMatches.IsMatch(charsOfTheCommand[i].ToString()))
                            {
                                charsOfTheCommand[i] = char.ToLower(charsOfTheCommand[i]);
                            }
                            else if (ToLowerMatches.IsMatch(charsOfTheCommand[i].ToString()))
                            {
                                charsOfTheCommand[i] = char.ToUpper(charsOfTheCommand[i]);
                            }
                        }
                        string s = new string(charsOfTheCommand);
                        matchesB.NoDigits = commandArgs[0];
                        matchesB.DigitsLetters = s;
                    }
                    else
                    {
                        matchesB.NoDigits = commandArgs[0];
                        matchesB.DigitsLetters = commandArgs[1];
                    }

                    broadcasts.Add(matchesB);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count < 1)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var cast in broadcasts)
                {
                    Console.WriteLine($"{cast.DigitsLetters} -> {cast.NoDigits}");
                }
            }
            Console.WriteLine("Messages:");
            if (messages.Count < 1)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var cast in messages)
                {
                    Console.WriteLine($"{Reverse(cast.Digits.ToString())} -> {cast.DigitsLetters}");
                }
            }

        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
