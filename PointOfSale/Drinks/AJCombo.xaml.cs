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
    /// Interaction logic for AJCombo.xaml
    /// </summary>
    public partial class AJCombo : UserControl
    {
        CurrentTicketControl parent;

        public AJCombo(CurrentTicketControl res, AretinoAppleJuice aj)
        {
            InitializeComponent();
            parent = res;
            DataContext = aj;
        }

        private void SizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is AretinoAppleJuice aj)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Small") aj.Size = Size.Small;
                    if (s.Name == "Medium") aj.Size = Size.Medium;
                    if (s.Name == "Large") aj.Size = Size.Large;
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
                parent.menuBorder1.Child = new ComboCustomScreen(parent);
        }
    }
}
