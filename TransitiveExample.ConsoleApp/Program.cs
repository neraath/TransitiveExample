using System;
using TransitiveExample.LibA;

namespace TransitiveExample.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Executing {typeof(Program).FullName}.Main()");
            var libA = new ExampleA();
            libA.Execute();
        }
    }
}
