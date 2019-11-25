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

        public int Cellphone { get; set; }

       public List<BankAccount> Accounts = new List<BankAccount>();


     
    }
}
