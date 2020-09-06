/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        /// <summary>
        /// These are the tests for Markarth Milk
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk mk = new MarkarthMilk();
            Assert.False(mk.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk mk = new MarkarthMilk();
            Assert.Equal(Size.Small, mk.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk mk = new MarkarthMilk();
            mk.Ice = true;
            Assert.True(mk.Ice);
            mk.Ice = false;
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk mk = new MarkarthMilk();
            mk.Size = Size.Large;
            Assert.Equal(Size.Large, mk.Size);
            mk.Size = Size.Medium;
            Assert.Equal(Size.Medium, mk.Size);
            mk.Size = Size.Small;
            Assert.Equal(Size.Small, mk.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk mk = new MarkarthMilk();
            mk.Size = size;
            Assert.Equal(price, mk.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk mk = new MarkarthMilk();
            mk.Size = size;
            Assert.Equal(cal, mk.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk mk = new MarkarthMilk();
            mk.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", mk.SpecialInstructions);
            else Assert.Empty(mk.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk mk = new MarkarthMilk();
            mk.Size = size;
            Assert.Equal(name, mk.ToString());
        }
    }
}