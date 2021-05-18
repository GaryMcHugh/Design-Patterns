using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Navigator
    {
        private IRouteBuilder routeBuilder;

        public Navigator(IRouteBuilder routeBuilder)
        {
            this.routeBuilder = routeBuilder;
        }

        public string Navigate(string startingPlace, string destination)
        {
            return routeBuilder.BuildRoute(startingPlace, destination);
        }
    }
}
