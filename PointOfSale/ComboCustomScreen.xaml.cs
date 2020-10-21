using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Combo_Custom_Screens;
using PointOfSale.Drinks;
using PointOfSale.Entrees;
using PointOfSale.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboCustomScreen.xaml
    /// </summary>
    public partial class ComboCustomScreen : UserControl
    {

        CurrentTicketControl parent;

        public ComboCustomScreen(CurrentTicketControl res)
        {
            InitializeComponent();
            parent = res;
        }

        private void EntreeSelect_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new EntreeSelectionCombo(parent);
        }

        private void SideSelect_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new SideSelectionCombo(parent);
        }

        private void DrinkSelect_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new DrinkSelectionCombo(parent);
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new MenuSelection(parent);
        }
    }
}
