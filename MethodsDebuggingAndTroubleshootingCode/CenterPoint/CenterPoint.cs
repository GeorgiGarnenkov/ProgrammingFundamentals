using System;

namespace CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            PrintCloseToCenterPoints(x1, y1, x2, y2);
        }

        static void PrintCloseToCenterPoints(double x1, double y1, double x2, double y2)
        {
            double firstCouple = Math.Abs(x1) + Math.Abs(y1);
            double secondCouple = Math.Abs(x2) + Math.Abs(y2);
            if (firstCouple >= secondCouple)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
