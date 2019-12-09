using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Customer
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Cellphone { get; set; }
        private List<BankAccount> Accounts { get; set; }

        public Customer() // gör en ny lista när systemet körs 
        {
            Accounts = new List<BankAccount>();
        }

        public List<BankAccount> GetMyList()
        {

            return Accounts;
        }


        public void AddAccount(BankAccount bankAccount)
        {

            Accounts.Add(bankAccount);

        }

        public override string ToString()// skriver ut mina prop
        {

            return $" {FirstName} {LastName} {Cellphone}";

        }


    }
}
