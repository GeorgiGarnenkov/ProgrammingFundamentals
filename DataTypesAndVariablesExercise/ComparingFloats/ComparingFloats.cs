using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = 0.0f;
            double eps = 0.000001;
            if (num1 > num2)
            {
                num3 = num1 - num2;
            }
            else if (num2 > num1)
            {
                num3 = num2 - num1;
            }

            if (num3 >= eps)
            {
                Console.WriteLine("False");
            }
            else if (num3 < eps)
            {
                Console.WriteLine("True");
            }
            
            
        }
    }
}
