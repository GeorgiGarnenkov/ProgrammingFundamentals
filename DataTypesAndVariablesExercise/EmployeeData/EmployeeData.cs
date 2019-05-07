using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string employeeFirstName = Console.ReadLine();
            string employeeLastName = Console.ReadLine();
            int employeeAge = int.Parse(Console.ReadLine());
            char employeeGender = char.Parse(Console.ReadLine());
            long employeePersonalNumber = long.Parse(Console.ReadLine());
            long employeeUniqueNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {employeeFirstName}");
            Console.WriteLine($"Last name: {employeeLastName}");
            Console.WriteLine($"Age: {employeeAge}");
            Console.WriteLine($"Gender: {employeeGender}");
            Console.WriteLine($"Personal ID: {employeePersonalNumber}");
            Console.WriteLine($"Unique Employee number: {employeeUniqueNumber}");
        }
    }
}
