using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesArray = new string[5, 4]
            {
                {"756","John Smith","IT","42000"},
                {"345","Ciaran Clarke","Finance","33000"},
                {"234","Kelly Anderson","Analytics","37000"},
                {"244","Jessica King","Management","62000"},
                {"857","Harold Wilson","CTO","90000"}
            };

            var target = new SalaryAdapter(new ThirdPartyBillingSystem());

            Console.WriteLine("HR system passes employee data array to the Adapter\n");

            target.ProcessCompanySalary(employeesArray);

            Console.Read();
        }
    }
}
