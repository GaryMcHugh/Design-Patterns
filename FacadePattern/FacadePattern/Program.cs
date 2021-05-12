using System;

namespace FacadePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //The Facade pattern provides a unified interface to interact with a complex subsystem
            //It is commonly used to hide the complexities of a system from the client

            //In this example, the mortgage facade is hiding the complexities of all of the checks needed to apply for a loan
            //The Mortgage facade class does all the heavy lifting and provides a simple method for a client to use



            // Facade
            var mortgage = new MortgageFacade();

            var customer = new Customer(100, "Mark Zuckerberg");
            var customer2 = new Customer(105, "Cookie Monster");

            // Evaluate mortgage eligibility for customer
            var eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));
            Console.WriteLine("\n===================================\n");

            
            eligible = mortgage.IsEligible(customer2, 201000);

            Console.WriteLine("\n" + customer2.Name + " has been " + (eligible ? "Approved" : "Rejected"));

            Console.ReadLine();
        }
    }
}
