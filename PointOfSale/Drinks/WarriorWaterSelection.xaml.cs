using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
/*
 * Elliot Peters
 * WarriorWaterSelection.xaml.cs
 */
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
    /// Interaction logic for WarriorWaterSelection.xaml
    /// </summary>
    public partial class WarriorWaterSelection : UserControl
    {

        CurrentTicketControl parent;

        private WarriorWater ww = new WarriorWater();

        /// <summary>
        /// assigns menuVal to the new object 
        /// </summary>
        /// <param name="menuVal">sets the menuVal to menuLook for the overall class</param>
        public WarriorWaterSelection(CurrentTicketControl menuVal, WarriorWater ww)
        {
            InitializeComponent();
            parent = menuVal;
            DataContext = ww;
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is WarriorWater)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Small") ww.Size = Size.Small;
                    if (s.Name == "Medium") ww.Size = Size.Medium;
                    if (s.Name == "Large") ww.Size = Size.Large;
                }
            }
        }
    }
}
