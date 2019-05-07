using System;

namespace LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static double Line(double x, double y)
        {
            double line = Math.Sqrt(Math.Pow(x, 2) + 
                                        Math.Pow(y, 2));
            return line;
        }

        static void PrintLine(double x1, double y1, double x2, double y2, 
                              double x3, double y3, double x4, double y4)
        {
            double line1 = Line(x1, y1);
            double line2 = Line(x2, y2);

            double line3 = Line(x3, y3);
            double line4 = Line(x4, y4);

            double lineLength1 = Math.Sqrt(Math.Pow((x1 - x2), 2) + 
                                             Math.Pow((y1 - y2), 2));

            double lineLength2 = Math.Sqrt(Math.Pow((x3 - x4), 2) + 
                                             Math.Pow((y3 - y4), 2));
            if (lineLength1 >= lineLength2)
            {
                if (line1 <= line2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            if (lineLength1 < lineLength2)
            {
                if (line3 <= line4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
    }
}
