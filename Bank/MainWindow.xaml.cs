﻿using System;
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

        List<Customer> customers = new List<Customer>();
        Customer ActiveCustomer = new Customer();

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if ((bool)radioBtnMakeDeposit.IsChecked)
            {
                bankAccount.MakeDeposit(decimal.Parse(txtMoney.Text));
            }

            else if ((bool)radioBtnMakeWithdrawal.IsChecked)
            {
                bankAccount.MakeWithdrawal(decimal.Parse(txtMoney.Text));

            }

        }



        private void btnSaveCustomer_Click(object sender, RoutedEventArgs e)
        {

             Customer ActiveCustomer = new Customer()
            {

                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Cellphone = decimal.Parse(txtCellPhone.Text)

            };
            customers.Add(ActiveCustomer);
            
            coboCustomer.ItemsSource= customers;


        }
            BankAccount bankAccount;
        public void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if ((bool)radioBtnCheckingAccount.IsChecked)
            {

                bankAccount = new CheckingAccount();
                ActiveCustomer.AddAccount(bankAccount);
            }

            else if ((bool)radioBtnRetirementAccount.IsChecked)
            {

                bankAccount = new RetirementAccount();
                ActiveCustomer.AddAccount(bankAccount);

            }
            else if ((bool)radioBtnSavingsAccount.IsChecked)
            {

                bankAccount = new SavingsAccount();
                ActiveCustomer.AddAccount(bankAccount);

            }


            if (0 < decimal.Parse(txtAddCredit.Text))
            {
                bankAccount.AddCredit(decimal.Parse(txtAddCredit.Text));
            }



            coboAccount.ItemsSource = null;
            coboAccount.ItemsSource = ActiveCustomer.GetMyList();

        }


        private void coboCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
       

    }
}
