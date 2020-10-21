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
    /// Interaction logic for CHCCombo.xaml
    /// </summary>
    public partial class CHCCombo : UserControl
    {
        CurrentTicketControl parent;

        public CHCCombo(CurrentTicketControl res, CandlehearthCoffee ch)
        {
            InitializeComponent();
            parent = res;
            DataContext = ch;
        }

        private void SizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new ComboCustomScreen(parent);
        }
    }
}
