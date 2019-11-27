using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {  
        
        
           
        public MainWindow()
        {
            InitializeComponent();
           
         



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Customer c = new Customer()
            {

                FirstName = "amir",
                LastName = "jama",
                Cellphone = 234214
            };
            List<Customer> customers = new List<Customer>();
            customers.Add(c);


            BankAccount bankAccount;
            bankAccount = new SavingsAccount();
            c.AddAccount(bankAccount);

            BankAccount bankAccount2;
            bankAccount2  = new RetirementAccount();
            c.AddAccount(bankAccount2);

            BankAccount bankAccount3;
            bankAccount3  = new CheckingAccount();
            c.AddAccount(bankAccount3);


            MessageBox.Show(c.ToString());
            
             
            bankAccount3.MakeDeposit(3243);
            bankAccount3.MakeWithdrawal(4000);
            MessageBox.Show(bankAccount3.Balance.ToString());



            //MessageBox.ShowMakeWithdrawal(343).ToString());


            //Assignment assignment = new Assignment();
            ////assignment.Accounts.Add();
            //if (assignment. > 3)
            //{



            //}






        }
        
    }
}
