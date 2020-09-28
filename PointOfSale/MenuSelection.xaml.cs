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

        void BriarheartBurgerB_Click(object sender, RoutedEventArgs e)
        {
            BriarheartBurger resItem = new BriarheartBurger();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void DoubleDraugrB_Click(object sender, RoutedEventArgs e)
        {
            DoubleDraugr resItem = new DoubleDraugr();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void ThalmorTripleB_Click(object sender, RoutedEventArgs e)
        {
            ThalmorTriple resItem = new ThalmorTriple();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void SmokehouseB_Click(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton resItem = new SmokehouseSkeleton();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void GardenOrcB_Click(object sender, RoutedEventArgs e)
        {
            GardenOrcOmlette resItem = new GardenOrcOmlette();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void ThugsTB_Click(object sender, RoutedEventArgs e)
        {
            ThugsTbone resItem = new ThugsTbone();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void SailorSodaB_Click(object sender, RoutedEventArgs e)
        {
            SailorSoda resItem = new SailorSoda();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void MarkarthMilkB_Click(object sender, RoutedEventArgs e)
        {
            MarkarthMilk resItem = new MarkarthMilk();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void AretinoB_Click(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice resItem = new AretinoAppleJuice();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void CandlehearthB_Click(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee resItem = new CandlehearthCoffee();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void WarriorWB_Click(object sender, RoutedEventArgs e)
        {
            WarriorWater resItem = new WarriorWater();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void VokunSaladB_Click(object sender, RoutedEventArgs e)
        {
            VokunSalad resItem = new VokunSalad();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void FriedMB_Click(object sender, RoutedEventArgs e)
        {
            FriedMiraak resItem = new FriedMiraak();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void MadOB_Click(object sender, RoutedEventArgs e)
        {
            MadOtarGrits resItem = new MadOtarGrits();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }

        void DragonbornB_Click(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries resItem = new DragonbornWaffleFries();
            Selected?.Invoke(this, new SelEventHandler() { item = resItem });
        }
    }
}
