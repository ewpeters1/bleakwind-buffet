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
    /// Interaction logic for SailorSCombo.xaml
    /// </summary>
    public partial class SailorSCombo : UserControl
    {
        CurrentTicketControl parent;

        public SailorSCombo(CurrentTicketControl res, SailorSoda ss)
        {
            InitializeComponent();
            parent = res;
            DataContext = ss;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new ComboCustomScreen(parent);
        }

        private void SizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is SailorSoda ss)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Small") ss.Size = Size.Small;
                    if (s.Name == "Medium") ss.Size = Size.Medium;
                    if (s.Name == "Large") ss.Size = Size.Large;

                }
            }
        }

        private void FlavorBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is SailorSoda ss)
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
