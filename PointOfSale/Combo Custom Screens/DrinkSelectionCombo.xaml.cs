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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.Entrees;
using BleakwindBuffet.Data;
using PointOfSale.Drinks;
using PointOfSale.Sides;

namespace PointOfSale.Combo_Custom_Screens
{
    /// <summary>
    /// Interaction logic for DrinkSelectionCombo.xaml
    /// </summary>
    public partial class DrinkSelectionCombo : UserControl
    {

        CurrentTicketControl parent;

        public DrinkSelectionCombo(CurrentTicketControl res)
        {
            InitializeComponent();
            parent = res;
        }

        /// <summary>
        /// This creates a press for the Sailor Soda, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void SailorSodaB(object sender, RoutedEventArgs e)
        {
            SailorSoda ss = new SailorSoda();
            SailorSCombo item = new SailorSCombo(parent, ss);
            parent.menuBorder1.Child = item;
            parent._combo.Drink = ss;
        }

        /// <summary>
        /// This creates a press for the Markarth Milk, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void MarkarthMilkB(object sender, RoutedEventArgs e)
        {
            MarkarthMilk mm = new MarkarthMilk();
            MMCombo item = new MMCombo(parent, mm);
            parent.menuBorder1.Child = item;
            parent._combo.Drink = mm; 
        }

        /// <summary>
        /// This creates a press for the Aretino Apple juice, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void AretinoB(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            AJCombo item = new AJCombo(parent, aj);
            parent.menuBorder1.Child = item;
            parent._combo.Drink = aj;
        }

        /// <summary>
        /// This creates a press for the Candlehearth coffee, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void CandlehearthB(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            CHCCombo item = new CHCCombo(parent, cc);
            parent.menuBorder1.Child = item;
            parent._combo.Drink = cc;
        }

        /// <summary>
        /// This creates a press for the Warrior Water, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void WarriorWB(object sender, RoutedEventArgs e)
        {
            WarriorWater ww = new WarriorWater();
            WWCombo item = new WWCombo(parent, ww);
            parent.menuBorder1.Child = item;
            parent._combo.Drink = ww;
        }

        private void FinishClick_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder1.Child = new ComboCustomScreen(parent);
        }
    }
}
