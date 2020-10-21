using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace PointOfSale.Entrees
{
    /// <summary>
    /// Interaction logic for TTCombo.xaml
    /// </summary>
    public partial class TTCombo : UserControl
    {
        CurrentTicketControl parent;

        public TTCombo(CurrentTicketControl res, ThalmorTriple tt)
        {
            InitializeComponent();
            parent = res;
            DataContext = tt;
        }

        private void AddDone_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new ComboCustomScreen(parent);
        }
    }
}
