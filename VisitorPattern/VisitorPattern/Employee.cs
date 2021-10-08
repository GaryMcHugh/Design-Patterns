using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    //Concrete Class which implements all methods defined by visitable
    public class Employee : IVisitable
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public int VacationEntitlement { get; set; }

        public Employee(string name, double salary, int vacationDays)
        {
            Name = name;
            Salary = salary;
            VacationEntitlement = vacationDays;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
