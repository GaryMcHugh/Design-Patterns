using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    //Element class, defines methods to be implemented by classes that can be visited
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}
