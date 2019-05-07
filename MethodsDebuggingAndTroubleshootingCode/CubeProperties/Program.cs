using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double calcParameter = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            CalcCubeParameters(calcParameter, parameter);
        }

        static void CalcCubeParameters(double calcParameter, string parameter)
        {
            if (parameter == "face")
            {
                calcParameter = Math.Sqrt(2 * Math.Pow(calcParameter, 2));
                Console.WriteLine($"{calcParameter:f2}");
            }
            else if (parameter == "space")
            {
                calcParameter = Math.Sqrt(3 * Math.Pow(calcParameter, 2));
                Console.WriteLine($"{calcParameter:f2}");
            }
            else if (parameter == "volume")
            {
                calcParameter = Math.Pow(calcParameter, 3);
                Console.WriteLine($"{calcParameter:f2}");
            }
            else if (parameter == "area")
            {
                calcParameter = 6 * Math.Pow(calcParameter, 2);
                Console.WriteLine($"{calcParameter:f2}");
            }
        }
    }
}
