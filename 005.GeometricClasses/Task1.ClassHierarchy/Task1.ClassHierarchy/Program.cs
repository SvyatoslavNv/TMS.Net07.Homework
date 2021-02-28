using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ClassHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle1 = new Rectangle(
                new Point(0, 0),
                new Point(0, 4),
                new Point(4, 4),
                new Point(4, 0));

            var triangle1 = new Triangle(
                new Point(0, 0),
                new Point(0, 4),
                new Point(4, 4));

            ShapeManager.PrintShapePerimeter(rectangle1);
            ShapeManager.PrintShapePerimeter(triangle1);
        }
    }

    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point SetX(int newX)
        {
            return new Point(newX, Y);
        }
        public Point SetY(int newY)
        {
            return new Point(X, newY);
        }

        public double GetDistance(Point target)
        {
            var width = X - target.X;
            var height = Y - target.Y;

            return Math.Sqrt(width * width + height * height);
        }

        public int GetXDistance(Point target)
        {
            return Math.Abs(X - target.X);
        }

        public int GetYDistance(Point target)
        {
            return Math.Abs(Y - target.Y);
        }
    }

    public abstract class Shape
    {
        public abstract double GetPerimeter();
        public abstract double GetSquare();
    }
    
    public class Triangle : Shape
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }

        public Triangle(Point a, Point b, Point c)
        {
            A = a ?? throw new ArgumentNullException(nameof(a));
            B = b ?? throw new ArgumentNullException(nameof(b));
            C = c ?? throw new ArgumentNullException(nameof(c));
        }
        
        public override double GetPerimeter()
        {
            return A.GetDistance(B) + B.GetDistance(C) + C.GetDistance(A);
        }
        
        public override double GetSquare()
        {
            throw new NotImplementedException();
        }
    }

    public class Rectangle : Shape
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }
        public Point D { get; }

        public Rectangle(Point a, Point b, Point c, Point d)
        {
            A = a ?? throw new ArgumentNullException(nameof(a));
            B = b ?? throw new ArgumentNullException(nameof(b));
            C = c ?? throw new ArgumentNullException(nameof(c));
            D = d ?? throw new ArgumentNullException(nameof(d));
        }

        public override double GetPerimeter()
        {
            return A.GetDistance(B) + B.GetDistance(C) + C.GetDistance(D) + D.GetDistance(A);
        }

        public override double GetSquare()
        {
            var width = GetWidth();
            var height = GetHeight();

            return width * height;
        }

        private int GetWidth()
        {
            return Math.Abs(A.X - B.X);
        }

        private int GetHeight()
        {
            return Math.Abs(A.Y - B.Y);
        }
    }

    public class ShapeManager
    {
        public static void PrintShapePerimeter(Shape shape)
        {
            Console.WriteLine($"Perimeter of {shape.GetType().Name} is {shape.GetPerimeter()}");
        }
        
        public static void PrintShapeSquare(Shape shape)
        {
            Console.WriteLine($"Square of {shape.GetType().Name} is {shape.GetSquare()}");
        }
    }

    public class ConsoleLogger
    {
        public void Log(Rectangle rectangle)
        {

        }

        public void Log(Triangle triangle)
        {

        }
    }
}
