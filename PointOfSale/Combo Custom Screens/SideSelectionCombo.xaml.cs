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


namespace PointOfSale.Combo_Custom_Screens
{
    /// <summary>
    /// Interaction logic for SideSelectionCombo.xaml
    /// </summary>
    public partial class SideSelectionCombo : UserControl
    {
        CurrentTicketControl parent;

        public SideSelectionCombo(CurrentTicketControl res)
        {
            InitializeComponent();
            parent = res;
        }

        /// <summary>
        /// This creates a press for the Vokun Salad, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void VokunSaladB(object sender, RoutedEventArgs e)
        {
            VokunSalad vs = new VokunSalad();
            VSCombo item = new VSCombo(parent, vs);
            parent.menuBorder1.Child = item;
            parent._combo.Side = vs;
        }

        /// <summary>
        /// This creates a press for the Fried Miraak, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void FriedMB(object sender, RoutedEventArgs e)
        {
            FriedMiraak fm = new FriedMiraak();
            FMCombo item = new FMCombo(parent, fm);
            parent.menuBorder1.Child = item;
            parent._combo.Side = fm;
        }

        /// <summary>
        /// This creates a press for the Mad Ortar Grits, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void MadOB(object sender, RoutedEventArgs e)
        {
            MadOtarGrits mg = new MadOtarGrits();
            MOGCombo item = new MOGCombo(parent, mg);
            parent.menuBorder1.Child = item;
            parent._combo.Side = mg;
        }

        /// <summary>
        /// This creates a press for the Dragonborn fries, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void DragonBornB(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            DWFCombo item = new DWFCombo(parent, dw);
            parent.menuBorder1.Child = item;
            parent._combo.Side = dw;
        }

        private void FinishClick_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new ComboCustomScreen(parent);
        }
    }
}
