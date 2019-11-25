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

                FirstName="amir",
                LastName="jama",
               Cellphone = 234214
            };

       
            List<Customer> customers = new List<Customer>();
            customers.Add(c);

            SavingsAccount s = new SavingsAccount()
            {
                AccountType = "sparkonto",
                Balance= 6000,
                Credit= 0

            };
            c.Accounts.Add(s);

            RetirementAccount r = new RetirementAccount() 
            {
                AccountType = "Pensionsspar",
                Balance = 6000,
                Credit = 0

            };

            c.Accounts.Add(r);



             MessageBox.Show($"du har {s}");
            


        }
    }
}
