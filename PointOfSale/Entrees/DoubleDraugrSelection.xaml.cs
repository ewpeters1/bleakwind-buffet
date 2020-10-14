/*
 * Elliot Peters
 * DoubleDraugrSelection.xaml.cs
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
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale.Entrees
{
    /// <summary>
    /// Interaction logic for DoubleDraugrSelection.xaml
    /// </summary>
    public partial class DoubleDraugrSelection : UserControl
    {


        CurrentTicketControl parent;

        /// <summary>
        /// assigns menuVal to the new object 
        /// </summary>
        /// <param name="menuVal">sets the menuVal to menuLook for the overall class</param>
        public DoubleDraugrSelection(DoubleDraugr dd, CurrentTicketControl menu)
        {
            InitializeComponent();
            parent = menu;
            DataContext = dd;
        }

        /// <summary>
        /// Creates back click event which reurn the border to its original display of the menu selection
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Button Event</param>
        void BackClick(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new MenuSelection(parent);
        }
    }
}
