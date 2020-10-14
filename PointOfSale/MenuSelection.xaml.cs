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
using PointOfSale.Entrees;
using BleakwindBuffet.Data;
using PointOfSale.Drinks;
using PointOfSale.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {

        CurrentTicketControl parent;

        /// <summary>
        /// initialzes the component
        /// </summary>
        public MenuSelection(CurrentTicketControl res)
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
            BrairheartBurgerSelection item = new BrairheartBurgerSelection(new BriarheartBurger(), parent);
            parent.menuBorder1.Child = item;
            Order o = (Order)parent.DataContext;
            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// This creates a press for the Philly Poacher, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void PhillyPoacherB(object sender, RoutedEventArgs e)
        {
            PhillyPoacherSelection item = new PhillyPoacherSelection(new PhillyPoacher(), parent);
            parent.menuBorder1.Child = item;
            Order o = (Order)parent.DataContext;
            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// This creates a press for the Double Draugr, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void DoubleDraugrB(object sender, RoutedEventArgs e)
        {
            DoubleDraugrSelection item = new DoubleDraugrSelection(new DoubleDraugr(), parent);
            parent.menuBorder1.Child = item;
            Order o = (Order)parent.DataContext;
            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// This creates a press for the Thalmor Triple, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void ThalmorTripleB(object sender, RoutedEventArgs e)
        {
            ThalmorTripleSelection item = new ThalmorTripleSelection(parent, new ThalmorTriple());
            parent.menuBorder1.Child = item;
            Order o = (Order)parent.DataContext;
            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// This creates a press for the Smokehouse Skeleton, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void SmokehouseB(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeletonSelection item = new SmokehouseSkeletonSelection(parent, new SmokehouseSkeleton());
            parent.menuBorder1.Child = item;
            Order o = (Order)parent.DataContext;
            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// This creates a press for the GGarden Orc Omlette, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void GardenOrcB(object sender, RoutedEventArgs e)
        {
            GardenOrcSelection item = new GardenOrcSelection(new GardenOrcOmlette(), parent);
            parent.menuBorder1.Child = item;
            Order o = (Order)parent.DataContext;
            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// This creates a press for the Thugs Tbone, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void ThugsTB(object sender, RoutedEventArgs e)
        {
            Order o = (Order)parent.DataContext;
            o.Add(new ThugsTbone());
        }

        /// <summary>
        /// This creates a press for the Sailor Soda, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void SailorSodaB(object sender, RoutedEventArgs e)
        {
            SailorSodaSelection item = new SailorSodaSelection(parent, new SailorSoda());
            parent.menuBorder1.Child = item;
            Order o = (Order)parent.DataContext;
            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// This creates a press for the Markarth Milk, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void MarkarthMilkB(object sender, RoutedEventArgs e)
        {
            MarkarthMilkSelection item = new MarkarthMilkSelection(parent, new MarkarthMilk());
            parent.menuBorder1.Child = item;
            Order o = (Order)parent.DataContext;
            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// This creates a press for the Aretino Apple juice, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void AretinoB(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuiceSelection item = new AretinoAppleJuiceSelection(parent, new AretinoAppleJuice());
            parent.menuBorder1.Child = item;
            Order o = (Order)parent.DataContext;
            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// This creates a press for the Candlehearth coffee, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void CandlehearthB(object sender, RoutedEventArgs e)
        {
            CandleHearthCoffeeSelection item = new CandleHearthCoffeeSelection(parent, new CandlehearthCoffee());
            parent.menuBorder1.Child = item;
            Order o = (Order)parent.DataContext;
            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// This creates a press for the Warrior Water, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void WarriorWB(object sender, RoutedEventArgs e)
        {
            WarriorWaterSelection item = new WarriorWaterSelection(parent, new WarriorWater());
            parent.menuBorder1.Child = item;
            Order o = (Order)parent.DataContext;
            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// This creates a press for the Vokun Salad, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void VokunSaladB(object sender, RoutedEventArgs e)
        {
            VokunSaladSelection item = new VokunSaladSelection(parent, new VokunSalad());
            parent.menuBorder1.Child = item;
            Order o = (Order)parent.DataContext;
            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// This creates a press for the Fried Miraak, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void FriedMB(object sender, RoutedEventArgs e)
        {
            FriedMiraakSelection item = new FriedMiraakSelection(parent, new FriedMiraak());
            parent.menuBorder1.Child = item;
            Order o = (Order)parent.DataContext;
            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// This creates a press for the Mad Ortar Grits, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void MadOB(object sender, RoutedEventArgs e)
        {
            MadOtarGritsSelection item = new MadOtarGritsSelection(parent, new MadOtarGrits());
            parent.menuBorder1.Child = item;
            Order o = (Order)parent.DataContext;
            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// This creates a press for the Dragonborn fries, and allows for the correct child of the button to become the main border.
        /// </summary>
        /// <param name="sender">the sender object</param>
        /// <param name="e">the buttno event</param>
        void DragonBornB(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFriesSelection item = new DragonbornWaffleFriesSelection(parent, new DragonbornWaffleFries());
            parent.menuBorder1.Child = item;
            Order o = (Order)parent.DataContext;
            o.Add((IOrderItem)item.DataContext);
        }
    }
}
