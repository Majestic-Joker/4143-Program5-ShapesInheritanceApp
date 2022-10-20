using System;
using System.Collections.Generic;

namespace ShapesLibrary
{
    public interface ICalculable
    {
        double Height { get; }
        double Width { get; }
        double Perimeter { get; }
        double Area { get; }
        double Distance(PolygonPoint p1, PolygonPoint p2);
    }

    public class PolygonPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PolygonPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public abstract class Quadrilateral : ICalculable
    {
        protected PolygonPoint lowerLeft;
        protected PolygonPoint upperLeft;
        protected PolygonPoint lowerRight;
        protected PolygonPoint upperRight;
        protected string description;

        public abstract double Height { get; }
        public abstract double Width { get; }
        public abstract double Area { get; }
        public abstract double Perimeter { get; }

        public double Distance(PolygonPoint p1, PolygonPoint p2)
        {
            return Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
        }
    }

    public class Trapezoid : Quadrilateral
    {
        public override double Height => Math.Abs(lowerLeft.Y - upperLeft.Y);
        public override double Width => Distance(lowerLeft, lowerRight);
        public override double Area => ((Distance(upperLeft, upperRight)+Width)/2)*Height;
        public override double Perimeter => (Distance(lowerLeft, upperLeft)+Distance(upperLeft, upperRight)+Distance(upperRight, lowerRight)+Distance(lowerRight, lowerLeft));

        public Trapezoid(List<PolygonPoint> points)
        {
            lowerLeft = points[0];
            upperLeft = points[1];
            upperRight = points[2];
            lowerRight = points[3];
            description = "A trapezoid is a quadrilateral with only one pair of parallel sides.";
        }
    }

    public class Parallelogram : Quadrilateral
    {
        public override double Height => Math.Abs(lowerLeft.Y - upperLeft.Y);
        public override double Width => Distance(upperLeft, upperRight);
        public override double Area => Width * Height;
        public override double Perimeter => 2*(Distance(lowerLeft, upperLeft) + Width);

        public Parallelogram(List<PolygonPoint> points)
        {
            if (points.Count < 3)
                return;

            lowerLeft = points[0];
            upperLeft = points[1];
            upperRight = points[2];
            lowerRight = new PolygonPoint(lowerLeft.X+(int)Width, lowerLeft.Y);
            description = "A parallelogram is a quadrilateral with the two pairs of opposite sides being parallel.";
        }
    }

    public class Rectangle : Parallelogram
    {
        public Rectangle(List<PolygonPoint> points) : base(points)
        {
            lowerLeft = points[0];
            upperRight = points[1];
            upperLeft = new PolygonPoint(lowerLeft.X, upperRight.Y);
            lowerRight = new PolygonPoint(upperRight.X, lowerLeft.Y);
            description = "A rectangle is a parallelogram with 4 right angles.";
        }
    }

    public class Square : Rectangle
    {
        public Square(List<PolygonPoint> points) : base(points)
        {
            lowerLeft = points[0];
            upperLeft = points[1];
            upperRight = new PolygonPoint(upperLeft.X + (int)Height, upperLeft.Y);
            lowerRight = new PolygonPoint(upperRight.X, lowerLeft.Y);
            description = "A square is a rectangle with 4 sides of the same length.";
        }
    }
}
