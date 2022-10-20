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

        public PolygonPoint()
        {
            X = 0;
            Y = 0;
        }

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
        public string Description { get; protected set; }
        public string ObjectInfo { get; protected set; }
        public abstract double Height { get; }
        public abstract double Width { get; }
        public abstract double Area { get; }
        public abstract double Perimeter { get; }

        public PolygonPoint GetPoint(int i)
        {
            PolygonPoint point = new PolygonPoint();
            switch (i)
            {
                case 1:
                    point.X = lowerLeft.X;
                    point.Y = lowerLeft.Y;
                    break;
                case 2:
                    point.X = upperLeft.X;
                    point.Y = upperLeft.Y;
                    break;
                case 3:
                    point.X = upperRight.X;
                    point.Y = upperRight.Y;
                    break;
                case 4:
                    point.X = lowerRight.X;
                    point.Y = lowerRight.Y;
                    break;
            }

            return point;
        }

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
            Description = "A trapezoid is a quadrilateral with only one pair of parallel sides.";
            ObjectInfo = $"______Trapezoid|__{lowerLeft.X}__|__{lowerLeft.Y}__|__{upperLeft.X}__|__{upperLeft.Y}__|__{upperRight.X}__|__{upperRight.Y}__|__{lowerRight.X}__|__{lowerRight.Y}__|__{Area}__|__{Perimeter}__|\n";
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
            Description = "A parallelogram is a quadrilateral with the two pairs of opposite sides being parallel.";
            ObjectInfo = $"__Parallelogram|__{lowerLeft.X}__|__{lowerLeft.Y}__|__{upperLeft.X}__|__{upperLeft.Y}__|__{upperRight.X}__|__{upperRight.Y}__|__{lowerRight.X}__|__{lowerRight.Y}__|__{Area}__|__{Perimeter}__|\n";
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
            Description = "A rectangle is a parallelogram with 4 right angles.";
            ObjectInfo = $"______Rectangle|__{lowerLeft.X}__|__{lowerLeft.Y}__|__{upperLeft.X}__|__{upperLeft.Y}__|__{upperRight.X}__|__{upperRight.Y}__|__{lowerRight.X}__|__{lowerRight.Y}__|__{Area}__|__{Perimeter}__|\n";
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
            Description = "A square is a rectangle with 4 sides of the same length.";
            ObjectInfo = $"_________Square|__{lowerLeft.X}__|__{lowerLeft.Y}__|__{upperLeft.X}__|__{upperLeft.Y}__|__{upperRight.X}__|__{upperRight.Y}__|__{lowerRight.X}__|__{lowerRight.Y}__|__{Area}__|__{Perimeter}__|\n";
        }
    }
}
