using System.Runtime.InteropServices;

namespace AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrade    // !!! Може и >>>> AverageGrade => Grades.Average(); !!!

        {
            get { return Grades.Average(); }
        }
    }
    
    public class AverageGrades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student student = new Student();

                string[] inputArgs = Console.ReadLine().Split(' ');

                student.Name = inputArgs[0];
                student.Grades = inputArgs.Skip(1)
                    .Select(double.Parse)
                    .ToList();

                students.Add(student);
            }

            students
                .Where(s => s.AverageGrade >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.Name} -> {s.AverageGrade:f2}"));
        }
    }
}
