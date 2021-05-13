using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class ThirdPartyBillingSystem
    {
        public void ProcessSalaries(List<Employee> Employees)
        {
            foreach (var employee in Employees)
            {
                Console.WriteLine(employee.EmployeeName + " has been paid " + Math.Round(employee.Salary / 12, 2) + " for their monthly salary.");
            }
            Console.WriteLine("\nThird party system has finished processing employee salaries");
        }
    }
}
