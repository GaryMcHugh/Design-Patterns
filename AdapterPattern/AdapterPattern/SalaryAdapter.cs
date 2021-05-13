using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public class SalaryAdapter : ISalary
    {
        ThirdPartyBillingSystem _thirdPartyBillingSystem;

        public SalaryAdapter(ThirdPartyBillingSystem thirdPartyBillingSystem)
        {
            _thirdPartyBillingSystem = thirdPartyBillingSystem;
        }
        
        public void ProcessCompanySalary(string[,] employeesArray)
        {
            var Id = "";
            var Name = "";
            var Department ="";
            var Salary = "";

            var listEmployee = ConvertArrayToList(employeesArray, Id, Name, Department, Salary);

            _thirdPartyBillingSystem.ProcessSalaries(listEmployee);

        }

        private static List<Employee> ConvertArrayToList(string[,] employeesArray, string Id, string Name, string Department, string Salary)
        {
            var listEmployee = new List<Employee>();

            for (var i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (var j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = employeesArray[i, j];
                    }
                    else if (j == 2)
                    {
                        Department = employeesArray[i, j];
                    }
                    else
                    {
                        Salary = employeesArray[i, j];
                    }
                }

                listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Department, Convert.ToDecimal(Salary)));
            }

            Console.WriteLine("Adapter converted Array of Employee's to a List of Employee's \n");

            return listEmployee;
        }
    }
}
