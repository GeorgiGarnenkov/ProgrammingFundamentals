namespace MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {

        public string Name { get; set; }

        public List<DateTime> AttDates { get; set; }

        public List<string> Comment { get; set; }

    }

    public class MentorGroup
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end of dates")
            {
                string[] name = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);








                input = Console.ReadLine();
            }


        }
    }
}
