using System;

namespace FacadePattern
{
    public class MortgageFacade
    {
        private Bank _bank = new Bank();
        private Loan _loan = new Loan();
        private Credit _credit = new Credit();

        public bool IsEligible(Customer cust, int amount)
        {
            var isEligible = true;

            Console.WriteLine("{0} applies for {1} loan\n", cust.Name, amount);

            // Check eligibility of customer

            if (!_bank.IsActiveAccount(cust) || !_bank.HasSufficientSavings(cust, amount))
                isEligible = false;
            
            else if (!_loan.HasNoBadLoans(cust))
                isEligible = false;
            
            else if (!_credit.HasGoodCredit(cust))
                isEligible = false;

            return isEligible;
        }
    }
}
