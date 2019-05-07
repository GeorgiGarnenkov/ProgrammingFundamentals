namespace RectanglePosition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Rectangle
    {
        public double Top { get; set; }
        public double Left { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double Bottom
        {
            get { return Top + Height; }
        }

        public double Right
        {
            get { return Left + Width; }
        }

        public double CalcArea()
        {
            return Width * Height;
        }

        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) &&
                   (r.Top <= Top) && (r.Bottom >= Bottom);
        }

        public static Rectangle ReadRectangle()
        {
            var sizes = Console.ReadLine().Split().Select(int.Parse);

            Rectangle rectangle = new Rectangle()
            {
                Left = sizes.First(),
                Top = sizes.Skip(1).First(),
                Width = sizes.Skip(2).First(),
                Height = sizes.Skip(3).First()
            };
            return rectangle;
        }
    }
    public class RectanglePosition
    {
        public static void Main()
        {
            Rectangle r1 = Rectangle.ReadRectangle();
            Rectangle r2 = Rectangle.ReadRectangle();

            Console.WriteLine(r1.IsInside(r2) ? "Inside" : "Not inside");
        }


    }
}
