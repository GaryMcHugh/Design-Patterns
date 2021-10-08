using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class Employees
    {
        private List<Employee> _employees = new List<Employee>();

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Remove(Employee employee)
        {
            _employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var employee in _employees)
            {
                employee.Accept(visitor);
            }

            Console.WriteLine();
        }
    }
}
