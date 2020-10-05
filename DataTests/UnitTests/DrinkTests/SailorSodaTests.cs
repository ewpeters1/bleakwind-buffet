/*
 * Author: Zachery Brunner
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda sSoda = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(sSoda);
        }
        /// <summary>
        /// These are the tests for Sailor Soda
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda sSoda = new SailorSoda();
            Assert.True(sSoda.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda sSoda = new SailorSoda();
            Assert.Equal(Size.Small, sSoda.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda sSoda = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, sSoda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda sSoda = new SailorSoda();
            sSoda.Ice = true;
            Assert.True(sSoda.Ice);
            sSoda.Ice = false;
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda sSoda = new SailorSoda();
            sSoda.Size = Size.Large;
            Assert.Equal(Size.Large, sSoda.Size);
            sSoda.Size = Size.Medium;
            Assert.Equal(Size.Medium, sSoda.Size);
            sSoda.Size = Size.Small;
            Assert.Equal(Size.Small, sSoda.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda sSoda = new SailorSoda();
            sSoda.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, sSoda.Flavor);
            sSoda.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, sSoda.Flavor);
            sSoda.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, sSoda.Flavor);
            sSoda.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, sSoda.Flavor);
            sSoda.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, sSoda.Flavor);
            sSoda.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, sSoda.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda sSoda = new SailorSoda();
            sSoda.Size = size;
            Assert.Equal(price, sSoda.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda sSoda = new SailorSoda();
            sSoda.Size = size;
            Assert.Equal(cal, sSoda.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda sSoda = new SailorSoda();
            sSoda.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", sSoda.SpecialInstructions);
            else Assert.Empty(sSoda.SpecialInstructions);
        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda sSoda = new SailorSoda();
            sSoda.Size = size;
            sSoda.Flavor = flavor;
            Assert.Equal(name, sSoda.ToString());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {

            SailorSoda sailorSoda = new SailorSoda();
            Assert.PropertyChanged(sailorSoda, "Ice", () =>
            {
                sailorSoda.Ice = true;
            });

            Assert.PropertyChanged(sailorSoda, "Ice", () =>
            {
                sailorSoda.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            SailorSoda sailorSoda = new SailorSoda();

            Assert.PropertyChanged(sailorSoda, "Size", () =>
            {
                sailorSoda.Size = Size.Small;
            });

            Assert.PropertyChanged(sailorSoda, "Size", () =>
            {
                sailorSoda.Size = Size.Medium;
            });
            Assert.PropertyChanged(sailorSoda, "Size", () =>
            {
                sailorSoda.Size = Size.Large;
            });
        }


        [Fact]
        public void ChangingFlavorNotifiesFlavorProperty()
        {
            SailorSoda sailorSoda = new SailorSoda();

            Assert.PropertyChanged(sailorSoda, "Flavor", () =>
            {
                sailorSoda.Flavor = SodaFlavor.Blackberry;
            });

            Assert.PropertyChanged(sailorSoda, "Flavor", () =>
            {
                sailorSoda.Flavor = SodaFlavor.Cherry;
            });
            Assert.PropertyChanged(sailorSoda, "Flavor", () =>
            {
                sailorSoda.Flavor = SodaFlavor.Grapefruit;
            });
            Assert.PropertyChanged(sailorSoda, "Flavor", () =>
            {
                sailorSoda.Flavor = SodaFlavor.Lemon;
            });

            Assert.PropertyChanged(sailorSoda, "Flavor", () =>
            {
                sailorSoda.Flavor = SodaFlavor.Peach;
            });
            Assert.PropertyChanged(sailorSoda, "Flavor", () =>
            {
                sailorSoda.Flavor = SodaFlavor.Watermelon;
            });
        }
    }
}
