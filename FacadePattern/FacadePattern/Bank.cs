using System;
using System.Collections.Generic;

namespace FacadePattern
{
    public class Bank
    {
        List<int> ActiveAccountList  = new List<int> { 100, 102, 105 };

        public bool HasSufficientSavings(Customer cust, int amount)
        {
            Console.WriteLine("Check bank balance for " + cust.Name);

            if (cust.Id == 100 || cust.Id == 105)
                return true;

            return true;
        }

        public bool IsActiveAccount(Customer cust)
        {
            Console.WriteLine("Checking active account for " + cust.Name);

            if (ActiveAccountList.Contains(cust.Id))
                return true;

            return false;
        }
    }
}
