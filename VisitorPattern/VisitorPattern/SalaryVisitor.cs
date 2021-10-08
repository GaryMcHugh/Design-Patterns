using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    //concrete visitor implements IVisitor
    public class SalaryVisitor : IVisitor
    {
        public void Visit(IVisitable element)
        {
            var employee = element as Employee;

            //Employees get a 7% salary increase
            employee.Salary = employee.Salary * 1.07;
            Console.WriteLine(employee.GetType().Name + " " + employee.Name + "'s new salary is " + Math.Round(employee.Salary, 2));
        }
    }
}
