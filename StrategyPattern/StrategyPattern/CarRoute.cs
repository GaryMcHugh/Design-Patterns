using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class CarRoute : IRouteBuilder
    {
        public string BuildRoute(string startPoint, string destination)
        {
            var instructions = "";

            Console.WriteLine("Building driving route from  " + startPoint + " to " + destination + "...");

            instructions = "starting at " + startPoint + " drive down shop street for 2 miles, then take a left onto keeler street. Then " + destination + " will be on your right.\n";

            return instructions;
        }
    }
}
