/*
 * Elliot Peters
 * SailorSodaSelection.xaml.cs
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
    /// Interaction logic for SailorSodaSelection.xaml
    /// </summary>
    public partial class SailorSodaSelection : UserControl
    {
        /// <summary>
        /// Creates new Menu Overhad object
        /// </summary>
        private MenuOverheadControl menuLook = new MenuOverheadControl();

        private SailorSoda ss = new SailorSoda();

        /// <summary>
        /// assigns menuVal to the new object 
        /// </summary>
        /// <param name="menuVal">sets the menuVal to menuLook for the overall class</param>
        public SailorSodaSelection(MenuOverheadControl menuVal)
        {
            InitializeComponent();
            menuLook = menuVal;
        }

        /// <summary>
        /// Creates back click event which reurn the border to its original display of the menu selection
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Button Event</param>
        void BackClick(object sender, RoutedEventArgs e)
        {
            menuLook.menuBorder.Child = menuLook.menuSelect;
        }

        void SizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is SailorSoda)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Small") ss.Size = Size.Small;
                    if (s.Name == "Medium") ss.Size = Size.Medium;
                    if (s.Name == "Large") ss.Size = Size.Large;
                }
            }
        }

        void FlavorBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is SailorSoda)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Blackberry") ss.Flavor = SodaFlavor.Blackberry;
                    if (s.Name == "Cherry") ss.Flavor = SodaFlavor.Cherry; 
                    if (s.Name == "Grapefruit") ss.Flavor = SodaFlavor.Grapefruit; 
                    if (s.Name == "Lemon") ss.Flavor = SodaFlavor.Lemon; 
                    if (s.Name == "Peach") ss.Flavor = SodaFlavor.Peach; 
                    if (s.Name == "Watermelon") ss.Flavor = SodaFlavor.Watermelon; 
                }
            }
        }
    }
}
