﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Employee(int employeeId, string name, string department, decimal salary)
        {
            EmployeeId = employeeId;
            EmployeeName = name;
            Department = department;
            Salary = salary;
        }
    }
}
