using BleakwindBuffet.Data.Drinks;
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using Size = BleakwindBuffet.Data.Enums.Size;
namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for MMCombo.xaml
    /// </summary>
    public partial class MMCombo : UserControl
    {
        CurrentTicketControl parent;

        public MMCombo(CurrentTicketControl menuVal, MarkarthMilk mm)
        {
            InitializeComponent();
            parent = menuVal;
            DataContext = mm;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new ComboCustomScreen(parent);
        }

        private void SizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is MarkarthMilk mm)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Small") mm.Size = Size.Small;
                    if (s.Name == "Medium") mm.Size = Size.Medium;
                    if (s.Name == "Large") mm.Size = Size.Large;
                }
            }
        }
    }
}
