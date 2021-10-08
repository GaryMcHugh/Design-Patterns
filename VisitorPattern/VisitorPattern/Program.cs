using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //define employees
            var employeesList = new Employees();
            employeesList.Add(new Developer());
            employeesList.Add(new QA());
            employeesList.Add(new Manager());

            //each employee is visited with the defined visitor
            employeesList.Accept(new SalaryVisitor());
            employeesList.Accept(new VacationVisitor());

            //if we want to add more functions to employees, i.e. pension scheme contribution changes
            //we just define a new visitor that implements IVisitor

            Console.ReadLine(); 
        }
    }
}
