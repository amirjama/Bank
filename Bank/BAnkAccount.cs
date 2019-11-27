using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class BankAccount 
    {
        public string AccountType { get; protected set;}
        public decimal Balance { get; protected set; } 
        public decimal Credit { get; protected set;}

        public virtual void MakeDeposit(decimal amount)
        {
            
                Balance += amount;
         
        }

        public  virtual bool MakeWithdrawal(decimal amount)
        {
           
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public virtual string ToString1()// skriver ut mina propbertis 
        {

            return $"{Balance} {Credit} {AccountType}";

        }

    }
}
