/*
 * Elliot Peters
 * CurrentTicketControl.cs
 * Will control the prices, tax, etc
 */
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CurrentTicketControl.xaml, wil control prices and order number, etc.
    /// </summary>
    public partial class CurrentTicketControl : UserControl
    {
        public CurrentTicketControl()
        {
            InitializeComponent();
        }
    }
}
