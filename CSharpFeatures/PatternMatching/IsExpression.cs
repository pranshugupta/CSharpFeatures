using Runner;
using System;

namespace PatternMatching
{
    public class IsExpression : IRunner
    {
        public void Run()
        {
            Method1();
            Method2();
        }

        private void Method1()
        {
            Person p;
            p = new Author("Pranshu", "Lost");

            if (p is Author)
            {
                Console.WriteLine($"{p.Name} is Author");
            }

            p = new Reader("Pranshu", 100);
            if (p is Reader)
            {
                Console.WriteLine($"{p.Name} is Reader");
            }
        }

        private void Method2()
        {
            Person p;
            p = new Author("Pranshu", "Lost");

            if (p is Author a)
            {
                Console.WriteLine($"{a.Name} is Author");
            }
        }
    }

    abstract class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }

    class Author : Person
    {

        public Author(string name, string title) : base(name)
        {
            Title = title;
        }
        public string Title { get; set; }
    }
    class Reader : Person
    {
        public Reader(string name, int price) : base(name)
        {
            Price = price;
        }
        public int Price { get; set; }
    }
}
