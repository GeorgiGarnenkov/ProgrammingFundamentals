using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Point ReadPoint()
        {
            var readTwoPoints = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Point makeOnePoint = new Point();
            makeOnePoint.X = readTwoPoints[0];
            makeOnePoint.Y = readTwoPoints[1];

            return makeOnePoint;
        }

        public static Point[] ReadPoints()
        {

            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }
            return points;
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            double a = p2.X - p1.X;
            double b = p2.Y - p1.Y;
            double distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return distance;
        }

        public static Point[] FindeClosestPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;

            for (int p1 = 0; p1 < points.Length; p1++)
            {
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    double distance = CalcDistance(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };
                    }
                }
            }
            return closestTwoPoints;
        }

        public static void PrintPoints(Point points)
        {
            Console.WriteLine($"{points.X}, {points.Y}");
        }

        public static void PrintDistance(Point[] point)
        {
            double distance = CalcDistance(point[0], point[1]);
            Console.WriteLine($"{distance:f3}");
        }
    }


    public class ClosestTwoPoints
    {
        public static void Main()
        {
            Point[] points = Point.ReadPoints();
            Point[] closestPoints = Point.FindeClosestPoints(points);

            Point.PrintDistance(closestPoints);

            Point.PrintPoints(closestPoints[0]);
            Point.PrintPoints(closestPoints[1]);
        }
    }
    
}
