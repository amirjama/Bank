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
            Balance = 10000;
            Credit = 0;


        }
    }
}
