using System.Security.Cryptography;

namespace DistanceBetweenPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            Point p1 = Point.ReadPoint();
            Point p2 = Point.ReadPoint();

            double distance = Point.CalcDistance(p1, p2);

            Console.WriteLine(distance);
        }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static double CalcDistance(Point p1, Point p2)
        {
            double a = p2.X - p1.X;
            double b = p2.Y - p1.Y;
            double distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return distance;
        }

        public static Point ReadPoint()
        {
            double[] readTwoPoints = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Point makeOnePoint = new Point();
            makeOnePoint.X = readTwoPoints[0];
            makeOnePoint.Y = readTwoPoints[1];

            return makeOnePoint;
        }
    }
}
