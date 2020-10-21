/*
 * Elliot Peters
 * CashPaymentControl
 */
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.Entrees;
using RoundRegister;
using PointOfSale.Drinks;
using PointOfSale.Sides;

namespace PointOfSale.RegisterItems
{
    /// <summary>
    /// Interaction logic for CashPaymentControl.xaml
    /// </summary>
    public partial class CashPaymentControl : UserControl
    {
        /// <summary>
        /// Cashview object
        /// </summary>
        CashViewOrginization cv;

        /// <summary>
        /// Parent to return to
        /// </summary>
        CurrentTicketControl parent;

        public CashPaymentControl(Order order,  CurrentTicketControl res)
        {
            InitializeComponent();
            parent = res;
            DataContext = order;
            if(DataContext is Order o)
            {
                cv = new CashViewOrginization(o.Total);
                DataContext = cv;
            }
        }

        /// <summary>
        /// Finalizes sale 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinalizeSale_Click(object sender, RoutedEventArgs e)
        {
            if (cv.UsingEnoughMoney)
            {
                cv.OpenDrawer();
                cv.FinializeSale();
                PrintReceipt();
                parent.DataContext = new Order();
                parent.menuBorder1.Child = new MenuSelection(parent);
            }
        }

        /// <summary>
        /// Returning to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnToOrder_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new MenuSelection(parent);
        }

        /// <summary>
        /// Prints reciept 
        /// </summary>
        public void PrintReceipt()
        {
            var order = (Order)parent.DataContext;
            RecieptPrinter.PrintLine("Order Number:" + order.Number.ToString());
            foreach (IOrderItem item in order.Item)
            {
                RecieptPrinter.PrintLine(item.ToString() + "....$" + item.Price);
                foreach (string s in item.SpecialInstructions)
                {
                    RecieptPrinter.PrintLine(s);
                }
            }
            RecieptPrinter.PrintLine("Subtotal....$" + order.Subtotal.ToString());
            RecieptPrinter.PrintLine("Tax....$" + order.Tax.ToString());
            RecieptPrinter.PrintLine("Total....$" + order.Total.ToString());
            RecieptPrinter.PrintLine("Payment Method Used....$" + "Cash");
            RecieptPrinter.PrintLine("Change Needed.....$" + cv.ChangeDue.ToString());
            RecieptPrinter.CutTape();
        }
    }
}
