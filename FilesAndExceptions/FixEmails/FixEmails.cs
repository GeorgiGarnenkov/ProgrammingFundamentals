using Microsoft.SqlServer.Server;

namespace FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    

    public class FixEmails
    {
        public static void Main()
        {
            Dictionary<string, string> emailList = new Dictionary<string, string>();

            string[] command = File.ReadAllLines("input.txt");

            string name = command[0];
            emailList[name] = string.Empty;

            for (int i = 1; i < command.Length; i++)
            {
                if (command[i] == "stop")
                {
                    break;
                }
                if (i % 2 == 0)
                {
                    name = command[i];
                    if (!emailList.ContainsKey(name))
                    {
                        emailList[name] = String.Empty;
                    }
                }
                else
                {
                    emailList[name] += command[i];
                }
                if (emailList.ContainsKey(name))
                {
                    if (emailList[name].EndsWith("us") || emailList[name].EndsWith("uk"))
                    {
                        emailList.Remove(name);
                    }
                }
            }
            string result = null;
            foreach (var entry in emailList)
            {
                result += $"{entry.Key} -> {entry.Value}{Environment.NewLine}";
            }
            File.WriteAllText("output.txt", result);
        }
    }
}
