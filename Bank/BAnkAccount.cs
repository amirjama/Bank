using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class BankAccount 
    {
        public string AccountType { get;  set;}
        public decimal Balance { get;  set; } 
        public int Credit { get;  set;}

        public decimal MakeDeposit(int amount, DateTime date)
        {

            

            return Balance += amount;
                 
          
           
        }

        public  double MakeWithdrawal(decimal amount)
        {
            if (BalanceWatch(amount))
            {
                Balance -= amount;
            }

            else if (!BalanceWatch(amount))
            {
              amount= amount;
            }
           

        }

        public bool BalanceWatch(decimal amount)
        {
            if (Balance <= amount)
            {
              

                return true;

            }
            else
            {
                return false;
            }



        }

        public void AddCustomer(string costomer)
        {


        }

    }
}
