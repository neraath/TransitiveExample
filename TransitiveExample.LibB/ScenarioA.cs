using System;

namespace TransitiveExample.LibB
{
    public class ScenarioA
    {
        public void Execute()
        {
            Console.WriteLine($"Executing {typeof(ScenarioA).FullName}.Execute()");
        }
    }
}
