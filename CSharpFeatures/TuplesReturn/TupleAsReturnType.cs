using Runner;
using System;

namespace TuplesReturn
{
    public class TupleAsReturnType : IRunner
    {
        public void Run()
        {
            Method1();
            Method2();
            Method3();
        }

        private void Method1()
        {
            (string Name, int Age, Gender Gender) NameAge = ("Pranshu", 28, Gender.Male);

            Console.WriteLine($"Name: {NameAge.Name}");
            Console.WriteLine($"Age: {NameAge.Age}");
            Console.WriteLine($"Gender: {NameAge.Gender}");
        }

        private void Method2()
        {
            var p = new Point(3.14, 2.71);
            (double X, double Y) = p;

            Console.WriteLine($"X point is {X}, Y point is {Y}");
        }

        private void Method3()
        {
            var p = new Point(3.14, 2.71);
            (double X, _) = p;          // Discard y point as we aren't going to use it anyway.

            Console.WriteLine($"X point is {X}");
        }
    }

    enum Gender
    {
        Male,
        Female
    }
    public class Point
    {
        // constructor
        public Point(double x, double y) => (X, Y) = (x, y);

        public double X { get; }
        public double Y { get; }

        // deconstructor
        public void Deconstruct(out double x, out double y) => (x, y) = (X, Y);

    }
}
