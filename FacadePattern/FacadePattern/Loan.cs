using System;

namespace FacadePattern
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer cust)
        {
            Console.WriteLine("Check loans for " + cust.Name);

            if(cust.Name.ToLower().Contains("a"))
                return true;

            return false;
        }
    }
}
