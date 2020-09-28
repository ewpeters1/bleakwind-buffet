/*
 * Elliot Peters
 * MenuOverheadControl.xaml.cs
 * This controls the two selection menus for the point of sale for the project
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Drinks;
using PointOfSale.Entrees;
using PointOfSale.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuOverheadControl.xaml
    /// </summary>
    public partial class MenuOverheadControl : UserControl
    {
        public MenuSelection menuSelect = new MenuSelection();

        /// <summary>
        /// Initializes the GUI and sets the correct borders
        /// </summary>
        public MenuOverheadControl()
        {
            InitializeComponent();
            menuSelect.Selected += NewItem_Click;
            menuBorder.Child = menuSelect;
        }

        /// <summary>
        /// This reads off of a button press, and makes sure that the button pressed opens up the corresponding custimization menu, which is the Selection menu. It sets this as the child and opens up that. 
        /// </summary>
        /// <param name="sender">button press</param>
        /// <param name="e">Reads the correct value from IOrderItem</param>
        void NewItem_Click(object sender, SelEventHandler e)
        {
            if (e.item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Entrees.Entree)))
            {
                if (e.item is BriarheartBurger) menuBorder.Child = new BrairheartBurgerSelection(this);
                if (e.item is DoubleDraugr) menuBorder.Child = new DoubleDraugrSelection(this);
                if (e.item is GardenOrcOmlette) menuBorder.Child = new GardenOrcSelection(this);
                if (e.item is PhillyPoacher) menuBorder.Child = new PhillyPoacherSelection(this);
                if (e.item is SmokehouseSkeleton) menuBorder.Child = new SmokehouseSkeletonSelection(this);
                if (e.item is ThalmorTriple) menuBorder.Child = new ThalmorTripleSelection(this);
            }

            if (e.item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Drinks.Drink)))
            {
                if (e.item is AretinoAppleJuice) menuBorder.Child = new AretinoAppleJuiceSelection(this);
                if (e.item is CandlehearthCoffee) menuBorder.Child = new CandleHearthCoffeeSelection(this);
                if (e.item is MarkarthMilk) menuBorder.Child = new MarkarthMilkSelection(this);
                if (e.item is SailorSoda) menuBorder.Child = new SailorSodaSelection(this);
                if (e.item is WarriorWater) menuBorder.Child = new WarriorWaterSelection(this);
            }

            if (e.item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Sides.Side)))
            {
                if (e.item is VokunSalad) menuBorder.Child = new VokunSaladSelection(this);
                if (e.item is MadOtarGrits) menuBorder.Child = new MadOtarGritsSelection(this);
                if (e.item is DragonbornWaffleFries) menuBorder.Child = new DragonbornWaffleFriesSelection(this);
                if (e.item is FriedMiraak) menuBorder.Child = new FriedMiraakSelection(this);
            }
        }
    }
}
