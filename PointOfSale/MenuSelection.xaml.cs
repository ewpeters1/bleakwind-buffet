/*
 * Elliot Peters
 * MenuSelection.xaml.cs
 * Creates button events for all buttons.
 */
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
        /// <summary>
        /// creates an event form the SelEventHandler class. This is used to invoke the correct item in the press
        /// </summary>
        public event EventHandler<SelEventHandler> Selected;

        /// <summary>
        /// initialzes the component
        /// </summary>
        public MenuSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This creates a press for the Briarheart Burger, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void BriarheartBurgerB(object sender, RoutedEventArgs e)
        {
            BriarheartBurger resItem = new BriarheartBurger();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        /// <summary>
        /// This creates a press for the Philly Poacher, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void PhillyPoacherB(object sender, RoutedEventArgs e)
        {
            PhillyPoacher resItem = new PhillyPoacher();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });

        }

        /// <summary>
        /// This creates a press for the Double Draugr, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void DoubleDraugrB(object sender, RoutedEventArgs e)
        {
            DoubleDraugr resItem = new DoubleDraugr();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        /// <summary>
        /// This creates a press for the Thalmor Triple, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void ThalmorTripleB(object sender, RoutedEventArgs e)
        {
            ThalmorTriple resItem = new ThalmorTriple();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        /// <summary>
        /// This creates a press for the Smokehouse Skeleton, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void SmokehouseB(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton resItem = new SmokehouseSkeleton();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        /// <summary>
        /// This creates a press for the GGarden Orc Omlette, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void GardenOrcB(object sender, RoutedEventArgs e)
        {
            GardenOrcOmlette resItem = new GardenOrcOmlette();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        /// <summary>
        /// This creates a press for the Thugs Tbone, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void ThugsTB(object sender, RoutedEventArgs e)
        {
            ThugsTbone resItem = new ThugsTbone();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        /// <summary>
        /// This creates a press for the Sailor Soda, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void SailorSodaB(object sender, RoutedEventArgs e)
        {
            SailorSoda resItem = new SailorSoda();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        /// <summary>
        /// This creates a press for the Markarth Milk, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void MarkarthMilkB(object sender, RoutedEventArgs e)
        {
            MarkarthMilk resItem = new MarkarthMilk();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        /// <summary>
        /// This creates a press for the Aretino Apple juice, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void AretinoB(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice resItem = new AretinoAppleJuice();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        /// <summary>
        /// This creates a press for the Candlehearth coffee, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void CandlehearthB(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee resItem = new CandlehearthCoffee();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        /// <summary>
        /// This creates a press for the Warrior Water, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void WarriorWB(object sender, RoutedEventArgs e)
        {
            WarriorWater resItem = new WarriorWater();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        /// <summary>
        /// This creates a press for the Vokun Salad, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void VokunSaladB(object sender, RoutedEventArgs e)
        {
            VokunSalad resItem = new VokunSalad();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        /// <summary>
        /// This creates a press for the Fried Miraak, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void FriedMB(object sender, RoutedEventArgs e)
        {
            FriedMiraak resItem = new FriedMiraak();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        /// <summary>
        /// This creates a press for the Mad Ortar Grits, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void MadOB(object sender, RoutedEventArgs e)
        {
            MadOtarGrits resItem = new MadOtarGrits();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        /// <summary>
        /// This creates a press for the Dragonborn fries, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void DragonBornB(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries resItem = new DragonbornWaffleFries();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }
    }
}
