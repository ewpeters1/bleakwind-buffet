﻿/*
 * Elliot Peters
 * CandleHearthCoffeeSelection.xaml.cs
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for CandleHearthCoffeeSelection.xaml
    /// </summary>
    public partial class CandleHearthCoffeeSelection : UserControl
    {


        CurrentTicketControl parent;

        /// <summary>
        /// assigns menuVal to the new object 
        /// </summary>
        /// <param name="menuVal">sets the menuVal to menuLook for the overall class</param>
        public CandleHearthCoffeeSelection(CurrentTicketControl menuVal, CandlehearthCoffee cc)
        {
            InitializeComponent();
            parent = menuVal;
            DataContext = cc;
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

        void SizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is CandlehearthCoffee cc)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Small") cc.Size = Size.Small;
                    if (s.Name == "Medium") cc.Size = Size.Medium;
                    if (s.Name == "Large") cc.Size = Size.Large;
                }
            }
        }
    }
}
