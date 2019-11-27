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
            Credit = 1000;
            
        }


        public override bool  MakeWithdrawal(decimal amount)
        {
            
            if (!base.MakeWithdrawal(amount))
            {
                if (Balance  + Credit >= amount)
                {
                 
                 Credit -=  amount - Balance ;
                 Balance -= amount;
                   return true;
                }
            }

            else if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

       

        
    }
}
