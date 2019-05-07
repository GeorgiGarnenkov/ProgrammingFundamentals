using System;
using System.Dynamic;

namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main()
        {
            string figure = Console.ReadLine();
            CalcTheAreaOfFigure(figure);
        }

        static void CalcTheAreaOfFigure(string figure)
        {
            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double triangleArea = side * height / 2;
                Console.WriteLine($"{triangleArea:f2}");
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double squareArea = side * side;
                Console.WriteLine($"{squareArea:f2}");
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double rectangleArea = width * height;
                Console.WriteLine($"{rectangleArea:f2}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{circleArea:f2}");
            }
        }
    }
}
