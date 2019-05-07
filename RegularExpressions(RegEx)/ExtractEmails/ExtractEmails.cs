namespace ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;


    public class ExtractEmails
    {
        public static void Main()
        {
            var regex = @"( |^)([a-z])+(\.|-)?\w{1,}@\w{1,}(\.|-)(\w{1,})((\.)?\w)+\b";

            var inpit = Console.ReadLine();

            var matched = Regex.Matches(inpit, regex);
            
            foreach (Match email in matched)
            {
                Console.WriteLine(email);
            }
        }
    }
}
