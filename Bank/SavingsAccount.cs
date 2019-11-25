using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SavingsAccount :BankAccount
    {
       public  SavingsAccount()
        {
            AccountType = "CheckingsAccount";
            Balance = 10000;
            Credit = 0;

        }
      
    }
}
