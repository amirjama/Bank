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

     
        BankAccount bankAccount;
        List<Customer> customers = new List<Customer>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            MessageBox.Show(c.ToString());
            

        }
        Customer c;
        private void btnSaveCustomer_Click(object sender, RoutedEventArgs e)
        {

             c= new Customer()
            {

                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Cellphone = decimal.Parse(txtCellPhone.Text)

            };
            customers.Add(c);
            
            coboCustomer.ItemsSource= customers;


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            coboCustomer.SelectedItem = c as Customer;

            //if (txtAddCredit != null)
            //{
            //    bankAccount.AddCredit(decimal.Parse(txtAddCredit.Text));
            //}  


            if ((bool)radioBtnCheckingAccount.IsChecked)
            {
            BankAccount bankAccount = new SavingsAccount();
            c.AddAccount(bankAccount);

            }

            if ((bool)radioBtnRetirementAccount.IsChecked)
            {

             bankAccount = new RetirementAccount();
            c.AddAccount(bankAccount);

            }
            if ((bool)radioBtnSavingsAccount.IsChecked)
            {

                //BankAccount bankAccount3;
                bankAccount = new CheckingAccount();
               c.AddAccount(bankAccount);

            }


        }
    }
}
