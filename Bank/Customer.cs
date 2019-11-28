﻿using System;
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

        public int Cellphone { get; set; }
        private List<BankAccount> Accounts { get; set; }

        public Customer()
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

        public override string ToString()// skriver ut mina propbertis 
        {

            return $" {FirstName} {LastName} {Cellphone}";

        }



        //foreach (BankAccount d in Accounts )
        //    {

        //    }




    }
}
