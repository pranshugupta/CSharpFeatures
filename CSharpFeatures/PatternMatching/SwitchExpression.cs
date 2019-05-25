using Runner;
using System;

namespace PatternMatching
{
    class SwitchExpression : IRunner
    {
        public void Run()
        {
            Method1();
            Method2();
        }

        private double Method1()
        {
            Object shape = new Square(10);

            switch (shape)
            {
                case Square s:
                    return s.Side * s.Side;
                case Circle c:
                    return c.Radius * c.Radius * 22 / 7;
                case Rectangle r:
                    return r.Height * r.Length;
                case Triangle t:
                    return t.Height * t.Base / 2;
                case var other:
                    return 0; ;
                default: throw new Exception("Not Valid shape");
            }
        }

        private double Method2()
        {
            object shape = new Square(10);

            switch (shape)
            {
                case null:
                case Square s when s.Side == 0:
                case Circle c when c.Radius == 0:
                case Rectangle r when (r.Height == 0 || r.Height == 0):
                case Triangle t when t.Height == 0 || t.Base == 0:
                    return 0;
                case Square s:
                    return s.Side * s.Side;
                case Circle c:
                    return c.Radius * c.Radius * 22 / 7;
                case Rectangle r:
                    return r.Height * r.Length;
                case Triangle t:
                    return t.Height * t.Base / 2;
                default: throw new Exception("Not Valid shape");
            }
        }
    }
    public class Square
    {
        public double Side { get; }

        public Square(double side)
        {
            Side = side;
        }
    }
    public class Circle
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
    public struct Rectangle
    {
        public double Length { get; }
        public double Height { get; }

        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }
    public class Triangle
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
    }

    public class Pentagon
    {
    }
}
