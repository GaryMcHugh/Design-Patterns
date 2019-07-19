using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern2
{
    interface IIterator
    {
        string FirstItem { get; }
        string NextItem { get; }
        string CurrentItem { get; }
        bool IsDone { get; }
    }
}
