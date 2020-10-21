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
using PointOfSale.Drinks;
using PointOfSale.Entrees;
using PointOfSale.Sides;

namespace PointOfSale.Combo_Custom_Screens
{
    /// <summary>
    /// Interaction logic for EntreeSelectionCombo.xaml
    /// </summary>
    public partial class EntreeSelectionCombo : UserControl
    {

        CurrentTicketControl parent;

        public EntreeSelectionCombo(CurrentTicketControl res)
        {
            InitializeComponent();
            parent = res;
        }

        /// <summary>
        /// This creates a press for the Briarheart Burger, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void BriarheartBurgerB(object sender, RoutedEventArgs e)
        {
            BriarheartBurger bb = new BriarheartBurger();
            BBCombo item = new BBCombo(parent, bb);
            parent.menuBorder1.Child = item;
            parent._combo.Entree = bb;
        }

        /// <summary>
        /// This creates a press for the Philly Poacher, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void PhillyPoacherB(object sender, RoutedEventArgs e)
        {
            PhillyPoacher pp = new PhillyPoacher();
            PPCombo item = new PPCombo(parent, pp);
            parent.menuBorder1.Child = item;
            parent._combo.Entree = pp;
        }

        /// <summary>
        /// This creates a press for the Double Draugr, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void DoubleDraugrB(object sender, RoutedEventArgs e)
        {
            DoubleDraugr dd = new DoubleDraugr();
            DDCombo item = new DDCombo(parent, dd);
            parent.menuBorder1.Child = item;
            parent._combo.Entree = dd;
        }

        /// <summary>
        /// This creates a press for the Thalmor Triple, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void ThalmorTripleB(object sender, RoutedEventArgs e)
        {
            ThalmorTriple tt = new ThalmorTriple();
            TTCombo item = new TTCombo(parent, tt);
            parent.menuBorder1.Child = item;
            parent._combo.Entree = tt;
        }

        /// <summary>
        /// This creates a press for the Smokehouse Skeleton, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void SmokehouseB(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            SSCombo item = new SSCombo(parent, ss);
            parent.menuBorder1.Child = item;
            parent._combo.Entree = ss;
        }

        /// <summary>
        /// This creates a press for the GGarden Orc Omlette, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void GardenOrcB(object sender, RoutedEventArgs e)
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();
            GOCombo item = new GOCombo(parent, gO);
            parent.menuBorder1.Child = item;
            parent._combo.Entree = gO;
        }

        /// <summary>
        /// This creates a press for the Thugs Tbone, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void ThugsTB(object sender, RoutedEventArgs e)
        {
            parent._combo.Entree = new ThugsTbone();
        }

        private void FinishClick_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new ComboCustomScreen(parent);
        }
    }
}
