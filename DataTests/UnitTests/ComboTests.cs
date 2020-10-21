using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ChangingEntreeNotfiesPrice()
        {
            ComboItems combo = new ComboItems(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Entree = bb;
            });
        }

        [Fact]
        public void ChangingEntreeNotfiesCalories()
        {
            ComboItems combo = new ComboItems(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Entree = bb;
            });
        }
        [Fact]
        public void ChangingEntreeNotfiesEntree()
        {
            ComboItems combo = new ComboItems(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(combo, "Entree", () =>
            {
                combo.Entree = bb;
            });
        }
        [Fact]
        public void ChangingEntreeNotfiesSpecialInstructions()
        {
            ComboItems combo = new ComboItems(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Entree = bb;
            });
        }

        [Fact]
        public void ChangingDrinkNotfiesPrice()
        {
            ComboItems combo = new ComboItems(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Drink = aj;
            });
        }
        [Fact]
        public void ChangingDrinkNotfiesDrinkProperty()
        {
            ComboItems combo = new ComboItems(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Drink = aj;
            });
        }
        [Fact]
        public void ChangingDrinkNotfiesCalories()
        {
            ComboItems combo = new ComboItems(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Drink = aj;
            });
        }
        [Fact]
        public void ChangingDrinkNotfiesSpecialInstructions()
        {
            ComboItems combo = new ComboItems(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Drink = aj;
            });
        }
        [Fact]
        public void ChangingSideNotifiesPrice()
        {
            ComboItems combo = new ComboItems(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            MadOtarGrits mg = new MadOtarGrits();
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Side = mg;
            });
        }
        [Fact]
        public void ChangingSideNotifiesCalories()
        {
            ComboItems combo = new ComboItems(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            MadOtarGrits mg = new MadOtarGrits();
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Side = mg;
            });
        }
        [Fact]
        public void ChangingSideNotifiesSide()
        {
            ComboItems combo = new ComboItems(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            MadOtarGrits mg = new MadOtarGrits();
            Assert.PropertyChanged(combo, "Side", () =>
            {
                combo.Side = mg;
            });
        }
        [Fact]
        public void ChangingSideNotifiesSpecialInstructions()
        {
            ComboItems combo = new ComboItems(new BriarheartBurger(), new DragonbornWaffleFries(), new SailorSoda());
            MadOtarGrits mg = new MadOtarGrits();
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Side = mg;
            });
        }
    }
}
