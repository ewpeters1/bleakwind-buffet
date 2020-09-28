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
        public event EventHandler<SelEventHandler> Selected;

        public MenuSelection()
        {
            InitializeComponent();
        }

        void BriarheartBurgerB(object sender, RoutedEventArgs e)
        {
            BriarheartBurger resItem = new BriarheartBurger();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void DoubleDraugrB(object sender, RoutedEventArgs e)
        {
            DoubleDraugr resItem = new DoubleDraugr();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void ThalmorTripleB(object sender, RoutedEventArgs e)
        {
            ThalmorTriple resItem = new ThalmorTriple();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void SmokehouseB(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton resItem = new SmokehouseSkeleton();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void GardenOrcB(object sender, RoutedEventArgs e)
        {
            GardenOrcOmlette resItem = new GardenOrcOmlette();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void ThugsTB(object sender, RoutedEventArgs e)
        {
            ThugsTbone resItem = new ThugsTbone();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void SailorSodaB(object sender, RoutedEventArgs e)
        {
            SailorSoda resItem = new SailorSoda();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void MarkarthMilkB(object sender, RoutedEventArgs e)
        {
            MarkarthMilk resItem = new MarkarthMilk();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void AretinoB(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice resItem = new AretinoAppleJuice();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void CandlehearthB(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee resItem = new CandlehearthCoffee();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void WarriorWB(object sender, RoutedEventArgs e)
        {
            WarriorWater resItem = new WarriorWater();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void VokunSaladB(object sender, RoutedEventArgs e)
        {
            VokunSalad resItem = new VokunSalad();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void FriedMB(object sender, RoutedEventArgs e)
        {
            FriedMiraak resItem = new FriedMiraak();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void MadOB(object sender, RoutedEventArgs e)
        {
            MadOtarGrits resItem = new MadOtarGrits();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void DragonBornB(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries resItem = new DragonbornWaffleFries();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }
    }
}
