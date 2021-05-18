using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IRouteBuilder
    {
        string BuildRoute(string startPoint, string destination);
    }
}
