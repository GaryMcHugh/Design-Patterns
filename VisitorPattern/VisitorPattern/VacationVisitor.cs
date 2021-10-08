using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    //concrete visitor implements IVisitor
    public class VacationVisitor : IVisitor
    {
        public void Visit(IVisitable element)
        {
            var employee = element as Employee;

            //employees get one extra vacation day a year
            employee.VacationEntitlement += 1;
            Console.WriteLine(employee.GetType().Name + " " + employee.Name + "'s new vacation entitlement is " + employee.VacationEntitlement);

        }
    }
}
