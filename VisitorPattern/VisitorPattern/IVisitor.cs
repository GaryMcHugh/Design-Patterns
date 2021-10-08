using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    //Visitor interface, declares a visit method for concrete classes to implement
    public interface IVisitor
    {
        void Visit(IVisitable element);
    }
}
