namespace PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class PhonebookUpgrade
    {
        public static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();
            var entry = Console.ReadLine();

            while (entry != "END")
            {
                string[] command = entry.Split(' ');

                if (command[0] == "A")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        phonebook[command[1]] = command[2];
                    }
                    else
                    {
                        phonebook.Add(command[1], command[2]);
                    }
                }
                else if (command[0] == "S")
                {

                    if (phonebook.ContainsKey(command[1]))
                    {
                        string value = phonebook[command[1]];
                        Console.WriteLine($"{command[1]} -> {value}");
                    }
                    else if (!(phonebook.ContainsKey(command[1])))
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }
                }
                else if (command[0] == "ListAll")
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }
                entry = Console.ReadLine();
            }
        }
    }
}
