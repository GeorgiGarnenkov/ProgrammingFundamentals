namespace FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class FixEmails
    {
        public static void Main()
        {
            Dictionary<string, string> emailList = new Dictionary<string, string>();
            var command = Console.ReadLine();

            while (command != "stop")
            {
                var name = command;
                var email = Console.ReadLine();

                if (!emailList.ContainsKey(name))
                {
                    emailList.Add(name, email);
                    if (email.EndsWith("us") || email.EndsWith("uk"))
                    {
                        emailList.Remove(name);
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var entry in emailList)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
