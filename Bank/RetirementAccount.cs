using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class RetirementAccount:BankAccount
    {
        public RetirementAccount()
        {
            AccountType = "RetirementAccount";
            Credit = 0;

        }

        public override bool MakeWithdrawal(decimal amount)
        {

            if (Balance >= amount * (decimal)1.1)
            {

                Balance -= amount * (decimal)1.1;
                return true;
            }
            return false;

            
        }

    }
}
