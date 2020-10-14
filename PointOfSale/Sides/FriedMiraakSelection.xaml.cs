/*
 * Elliot Peters
 * FriedMiraakSelectionSelection.xaml.cs
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
using Size = BleakwindBuffet.Data.Enums.Size;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale.Sides
{
    /// <summary>
    /// Interaction logic for FriedMiraakSelection.xaml
    /// </summary>
    public partial class FriedMiraakSelection : UserControl
    {

        private FriedMiraak fm = new FriedMiraak();

        CurrentTicketControl parent;

        /// <summary>
        /// assigns menuVal to the new object 
        /// </summary>
        /// <param name="menuVal">sets the menuVal to menuLook for the overall class</param>
        public FriedMiraakSelection(CurrentTicketControl menuVal , FriedMiraak fm)
        {
            InitializeComponent();
            parent = menuVal;
            DataContext = fm;
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

        /// <summary>
        /// Creates event using data binding
        /// </summary>
        /// <param name="sender">event</param>
        /// <param name="e">event</param>
        void SizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is FriedMiraak)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Small") fm.Size = Size.Small;
                    if (s.Name == "Medium") fm.Size = Size.Medium;
                    if (s.Name == "Large") fm.Size = Size.Large;
                }
            }
        }
    }
}
