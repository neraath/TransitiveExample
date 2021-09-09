using System;
using TransitiveExample.LibB;

namespace TransitiveExample.LibA
{
    public class ExampleA
    {
        public void Execute()
        {
            Console.WriteLine($"Executing {typeof(ExampleA).FullName}.Execute()");
            var scenarioA = new ScenarioA();
            scenarioA.Execute();
        }
    }
}
