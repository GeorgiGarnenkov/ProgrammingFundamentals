namespace IntersectionOfCircles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double R { get; set; }

        public static Point ReadPoints()
        {
            double[] readThreePoints = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Point makeThreePoints = new Point();
            makeThreePoints.X = readThreePoints[0];
            makeThreePoints.Y = readThreePoints[1];
            makeThreePoints.R = readThreePoints[2];

            return makeThreePoints;
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            double a = p2.X - p1.X;
            double b = p2.Y - p1.Y;
            double distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return distance;
        }

        public static double CalcSumRadius(Point r1, Point r2)
        {
            double sumRadiuses = r1.R + r2.R;

            return sumRadiuses;
        }

    }

    public class IntersectionOfCircles
    {
        public static void Main()
        {
            Point nums1 = Point.ReadPoints();
            Point nums2 = Point.ReadPoints();

            var distance = Point.CalcDistance(nums1, nums2);
            var radius = Point.CalcSumRadius(nums1, nums2);

            if (distance <= radius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
