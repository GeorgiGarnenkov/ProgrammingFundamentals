namespace AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    

    public class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double AverageGrade => Grades.Average();
    }
    
    public class AverageGrades
    {
        public static void Main()
        {
            
            string[] n = File.ReadAllLines("input.txt");

            List<Student> students = new List<Student>();

            for (int i = 1; i < n.Length; i++)
            {
                Student student = new Student();

                string[] inputArgs = n[i].Split(' ');

                student.Name = inputArgs[0];
                student.Grades = inputArgs.Skip(1)
                    .Select(double.Parse)
                    .ToList();

                students.Add(student);
            }
            
            foreach (var student in students.Where(s => s.AverageGrade >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList())
            {
                File.AppendAllText("output.txt", $"{student.Name} -> {student.AverageGrade:f2}{Environment.NewLine}");
            }
        }
    }
}
