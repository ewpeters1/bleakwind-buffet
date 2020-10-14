/*
 * Elliot Peters
 * CurrentTicketControl.cs
 * Will control the prices, tax, etc
 */
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CurrentTicketControl.xaml, wil control prices and order number, etc.
    /// </summary>
    public partial class CurrentTicketControl : UserControl
    {
        private Order _order;


        public CurrentTicketControl()
        {
            InitializeComponent();
            menuBorder1.Child = new MenuSelection(this);
            _order = new Order();
            DataContext = _order;
        }

        private void itemsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IOrderItem item = (IOrderItem)itemsListView.SelectedItem;
            if (item is BriarheartBurger) menuBorder1.Child = new BrairheartBurgerSelection((BriarheartBurger)item, this);
            else if (item is DoubleDraugr) menuBorder1.Child = new DoubleDraugrSelection((DoubleDraugr)item, this);
            else if (item is GardenOrcOmlette) menuBorder1.Child = new GardenOrcSelection((GardenOrcOmlette)item, this);
            else if (item is PhillyPoacher) menuBorder1.Child = new PhillyPoacherSelection((PhillyPoacher)item, this);
            else if (item is SmokehouseSkeleton) menuBorder1.Child = new SmokehouseSkeletonSelection(this, (SmokehouseSkeleton)item);
            else if (item is ThalmorTriple) menuBorder1.Child = new ThalmorTripleSelection(this, (ThalmorTriple)item);

            else if (item is AretinoAppleJuice) menuBorder1.Child = new AretinoAppleJuiceSelection(this, (AretinoAppleJuice)item);
            else if (item is MarkarthMilk) menuBorder1.Child = new MarkarthMilkSelection(this,(MarkarthMilk)item);
            else if (item is CandlehearthCoffee) menuBorder1.Child = new CandleHearthCoffeeSelection(this, (CandlehearthCoffee)item);
            else if (item is SailorSoda) menuBorder1.Child = new SailorSodaSelection(this, (SailorSoda)item);
            else if (item is WarriorWater) menuBorder1.Child = new WarriorWaterSelection(this, (WarriorWater)item);

            else if (item is DragonbornWaffleFries) menuBorder1.Child = new DragonbornWaffleFriesSelection(this, (DragonbornWaffleFries)item);
            else if (item is FriedMiraak) menuBorder1.Child = new FriedMiraakSelection(this, (FriedMiraak)item);
            else if (item is VokunSalad) menuBorder1.Child = new VokunSaladSelection(this, (VokunSalad)item);
            else if (item is MadOtarGrits) menuBorder1.Child = new MadOtarGritsSelection(this, (MadOtarGrits)item);

        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            _order.Clear();           
            menuBorder1.Child = new MenuSelection(this);
        }

        private void DeleteSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            IOrderItem item = (IOrderItem)itemsListView.SelectedItem;
            _order.Remove(item);
            menuBorder1.Child = new MenuSelection(this);
        }

        private void FinishOrderButton_Click(object sender, RoutedEventArgs e)
        {
            _order = new Order();
            DataContext = _order;
            menuBorder1.Child = new MenuSelection(this);
        }
    }
}
