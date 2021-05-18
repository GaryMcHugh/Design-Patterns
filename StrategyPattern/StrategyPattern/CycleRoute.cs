using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class CycleRoute : IRouteBuilder
    {
        public string BuildRoute(string startPoint, string destination)
        {
            var instructions = "";

            Console.WriteLine("Building cycle route from  " + startPoint + " to " + destination + "...");

            instructions = "start at " + startPoint + " use the cycle path down 5th street and turn right at 7th street and key street, then arrive at " + destination + "\n";

            return instructions;
        }
    }
}
