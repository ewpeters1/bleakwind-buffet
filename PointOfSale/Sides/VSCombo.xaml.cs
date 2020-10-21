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
    /// Interaction logic for VSCombo.xaml
    /// </summary>
    public partial class VSCombo : UserControl
    {
        CurrentTicketControl parent;

        public VSCombo(CurrentTicketControl res, VokunSalad vs)
        {
            InitializeComponent();
            parent = res;
            DataContext = vs;
        }

        private void SizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is VokunSalad vs)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Small") vs.Size = Size.Small;
                    if (s.Name == "Medium") vs.Size = Size.Medium;
                    if (s.Name == "Large") vs.Size = Size.Large;
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new ComboCustomScreen(parent);
        }
    }
}
