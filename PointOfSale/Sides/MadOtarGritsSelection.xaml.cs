/*
 * Elliot Peters
 * MadOtarGritsSelection.xaml.cs
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
    /// Interaction logic for MadOtarGritsSelection.xaml
    /// </summary>
    public partial class MadOtarGritsSelection : UserControl
    {
        /// <summary>
        /// Creates new Menu Overhad object
        /// </summary>
        private MenuOverheadControl menuLook = new MenuOverheadControl();

        private MadOtarGrits mg = new MadOtarGrits();

        /// <summary>
        /// assigns menuVal to the new object 
        /// </summary>
        /// <param name="menuVal">sets the menuVal to menuLook for the overall class</param>
        public MadOtarGritsSelection(MenuOverheadControl menuVal)
        {
            InitializeComponent();
            menuLook = menuVal;
            DataContext = mg;
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

        /// <summary>
        /// Event for binding Otar data with press
        /// </summary>
        /// <param name="sender">event</param>
        /// <param name="e">event</param>
        void SizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is MadOtarGrits)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Small") mg.Size = Size.Small;
                    if (s.Name == "Medium") mg.Size = Size.Medium;
                    if (s.Name == "Large") mg.Size = Size.Large;
                }
            }
        }
    }
}
