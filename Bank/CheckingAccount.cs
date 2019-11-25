using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
   public class CheckingAccount : BankAccount
    {
        public CheckingAccount() //konstruktor
        {
            AccountType = "CheckingsAccount";
            Balance = 10000;
            Credit = 3403;


        }
    }
}
