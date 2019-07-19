using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern2
{
    interface IAggregate
    {
        IIterator GetIterator();
        string this[int itemIndex] { set; get; }
        int Count { get; }
    }
}
