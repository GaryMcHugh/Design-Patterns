using System;

namespace FacadePattern
{
    public class Credit
    {
        public bool HasGoodCredit(Customer cust)
        {
            Console.WriteLine("Check credit score for " + cust.Name);

            if(cust.Id == 100)
                return true;

            return false;
        }
    }
}
