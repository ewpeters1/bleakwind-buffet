/*
 * Elliot Peters
 * PaymentOptionsScreen.cs
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Combo_Custom_Screens;
using PointOfSale.Drinks;
using PointOfSale.Entrees;
using PointOfSale.Sides;
using RoundRegister;

namespace PointOfSale.RegisterItems
{
    /// <summary>
    /// Interaction logic for PaymentOptionsScreen.xaml
    /// </summary>
    public partial class PaymentOptionsScreen : UserControl
    {
        /// <summary>
        /// parent current ticket
        /// </summary>
        CurrentTicketControl parent;

        /// <summary>
        /// payment type
        /// </summary>
        public string paymentType = "";

        /// <summary>
        /// Comnstructor
        /// </summary>
        /// <param name="res">This is the parent screen</param>
        public PaymentOptionsScreen(CurrentTicketControl res)
        {
            InitializeComponent();
            parent = res;
        }

        /// <summary>
        /// This changes to the cash register 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashSelection_Click(object sender, RoutedEventArgs e)
        {
            var order = (Order)DataContext;
            parent.menuBorder1.Child = new CashPaymentControl(order, parent);
        } 

        /// <summary>
        /// This allows for credit or debit and returns the correct reciept
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreditDebitSelection_Click(object sender, RoutedEventArgs e)
        {
            var order = (Order)DataContext;
            var options = CardReader.RunCard(order.Total);
            paymentType = "Card";
            if(options == CardTransactionResult.Approved)
            {
                PrintReceipt();
                parent.DataContext = new Order();
                parent.menuBorder1.Child = new MenuSelection(parent);             
            }
            if(options == CardTransactionResult.Declined)
            {
                MessageBox.Show("Sorry, your card has been declined!");
            }
            if (options == CardTransactionResult.IncorrectPin)
            {
                MessageBox.Show("Sorry, your pin is incorrect!");
            }
            if (options == CardTransactionResult.InsufficientFunds)
            {
                MessageBox.Show("Sorry, your card has insufficient funds!");
            }
            if (options == CardTransactionResult.ReadError)
            {
                MessageBox.Show("Sorry, try swiping again!");
            }
        }

        /// <summary>
        /// Method that prints the reciept to a file
        /// </summary>
        public void PrintReceipt()
        {
            var order = (Order)DataContext;
            RecieptPrinter.PrintLine("Order Number:" + order.Number.ToString());
            foreach(IOrderItem item in order.Item)
            {
                RecieptPrinter.PrintLine(item.ToString() + "....$" + item.Price);
                foreach(string s in item.SpecialInstructions)
                {
                    RecieptPrinter.PrintLine(s);
                }
            }
            RecieptPrinter.PrintLine("Subtotal....$" + order.Subtotal.ToString());
            RecieptPrinter.PrintLine("Tax....$" + order.Tax.ToString());
            RecieptPrinter.PrintLine("Total....$" + order.Total.ToString());
            RecieptPrinter.PrintLine("Payment Method Used....$" + paymentType);
            RecieptPrinter.PrintLine("Change Needed.....$");
            RecieptPrinter.CutTape();
        }

        /// <summary>
        /// Button event that returns to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new MenuSelection(parent);
        }
    }
}
