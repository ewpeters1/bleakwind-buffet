/*
 * Elliot Peters
 * DragonBornWaffleFriesSelection.xaml.cs
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
using BleakwindBuffet.Data;

namespace PointOfSale.Sides
{

    /// <summary>
    /// Interaction logic for DragonbornWaffleFriesSelection.xaml
    /// </summary>
    public partial class DragonbornWaffleFriesSelection : UserControl
    {

        CurrentTicketControl parent;
        /// <summary>
        /// Private backing variable 
        /// </summary>
        private DragonbornWaffleFries dw = new DragonbornWaffleFries();

        /// <summary>
        /// assigns menuVal to the new object 
        /// </summary>
        /// <param name="menuVal">sets the menuVal to menuLook for the overall class</param>
        public DragonbornWaffleFriesSelection(CurrentTicketControl menuVal, DragonbornWaffleFries dw)
        {
            InitializeComponent();
            parent = menuVal;
            DataContext = dw;
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
        /// Dragon born fries Event for chooosing correct values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is DragonbornWaffleFries)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Small") dw.Size = Size.Small;
                    if (s.Name == "Medium") dw.Size = Size.Medium;
                    if (s.Name == "Large") dw.Size = Size.Large;
                }
            }
        }
    }
}
