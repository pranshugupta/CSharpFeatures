using Runner;
using System;

namespace OutVariable
{
    public class InlineOutVariableDeclaration : IRunner
    {
        public void Run()
        {
            Method1();
            Method2();
        }

        void Method1()
        {
            if (int.TryParse("10", out int result))
            {
                Console.WriteLine($"{result}: Converted to int");
            }
        }
        void Method2()
        {
            if (int.TryParse("10", out var result))
            {
                Console.WriteLine($"{result}: Converted to int");
            }
        }
    }
}
