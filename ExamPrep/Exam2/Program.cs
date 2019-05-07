using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam2
{
    public class Program
    {
        public static void Main()
        {
            var stringInput = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "3:1")
                {
                    break;
                }
                var commandArgs = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (commandArgs.Count == 0)
                {
                    break;
                }
                var command = commandArgs[0];

                if (command == "merge")
                {
                    var startIndex = int.Parse(commandArgs[1]);
                    var endIndex = int.Parse(commandArgs[2]);

                    var concatwords = new List<string>();
                    if (startIndex > stringInput.Count)
                    {
                        continue;
                    }
                    if (endIndex > stringInput.Count && startIndex < stringInput.Count)
                    {
                        for (int j = startIndex; j < stringInput.Count; j++)
                        {
                            concatwords.Add(stringInput[j]);

                        }
                        stringInput.RemoveRange(startIndex, stringInput.Count - startIndex);
                    }
                    else if (endIndex < stringInput.Count && startIndex < stringInput.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concatwords.Add(stringInput[i]);

                        }
                        stringInput.RemoveRange(startIndex, endIndex - startIndex + 1);
                    }
                    if (concatwords.Count != 0)
                    {
                        var newWord = string.Join("", concatwords);
                        stringInput.Insert(startIndex, newWord);
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (command == "divide")
                {
                    var index = int.Parse(commandArgs[1]);
                    var partitions = int.Parse(commandArgs[2]);

                    if (index > stringInput.Count)
                    {
                        continue;
                    }
                    if (index <= stringInput.Count)
                    {
                        var wordForSplit = stringInput.ElementAt(index);

                        if (wordForSplit.Length / partitions > 0)
                        {
                            List<string> a = new List<string>();
                            for (int i = 0; i < wordForSplit.Length; i += wordForSplit.Length / partitions)
                            {
                                if ((i + (wordForSplit.Length / partitions)) < wordForSplit.Length)
                                    a.Add(wordForSplit.Substring(i, wordForSplit.Length / partitions));
                                else
                                    a.Add(wordForSplit.Substring(i));
                            }
                            stringInput.RemoveAt(index);
                            stringInput.InsertRange(index, a);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", stringInput));
        }
    }
}
