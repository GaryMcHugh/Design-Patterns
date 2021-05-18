using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class WalkingRoute : IRouteBuilder
    {
        public string BuildRoute(string startPoint, string destination)
        {
            var instructions = "";

            Console.WriteLine("Building scenic walking route from  " + startPoint + " to " + destination + "...");

            instructions = "start at " + startPoint + ", walk through the park to get to " + destination + "\n";

            return instructions;
        }
    }
}
