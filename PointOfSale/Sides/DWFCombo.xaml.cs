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
    /// Interaction logic for DWFCombo.xaml
    /// </summary>
    public partial class DWFCombo : UserControl
    {
        CurrentTicketControl parent;

        public DWFCombo(CurrentTicketControl res, DragonbornWaffleFries dw)
        {
            InitializeComponent();
            parent = res;
            DataContext = dw;

        }

        private void SizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is DragonbornWaffleFries dw)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Small") dw.Size = Size.Small;
                    if (s.Name == "Medium") dw.Size = Size.Medium;
                    if (s.Name == "Large") dw.Size = Size.Large;
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new ComboCustomScreen(parent);
        }
    }
}
