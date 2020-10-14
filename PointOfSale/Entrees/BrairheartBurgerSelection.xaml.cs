/*
 * Elliot Peters
 * BrairheartBurgerSelection.xaml.cs
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using BleakwindBuffet.Data;

namespace PointOfSale.Entrees
{
    /// <summary>
    /// Interaction logic for BrairheartBurgerSelection.xaml
    /// </summary>
    public partial class BrairheartBurgerSelection : UserControl
    {
        CurrentTicketControl parent;

        /// <summary>
        /// assigns menuVal to the new object 
        /// </summary>
        /// <param name="menuVal">sets the menuVal to menuLook for the overall class</param>
        public BrairheartBurgerSelection(BriarheartBurger bb, CurrentTicketControl menu)
        {
            InitializeComponent();
            parent = menu;
            DataContext = bb;
        }

        /// <summary>
        /// Creates back click event which reurn the border to its original display of the menu selection
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Button Event</param>
        void AddDone_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new MenuSelection(parent);           
        }
    }
}
