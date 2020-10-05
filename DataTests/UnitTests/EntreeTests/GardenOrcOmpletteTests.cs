/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// These are the tests for The garden Orc Omlette
    /// </summary>
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();
            Assert.IsAssignableFrom<Entree>(gO);
        }
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();
            Assert.True(gO.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();
            Assert.True(gO.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();
            Assert.True(gO.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();
            Assert.True(gO.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();
            gO.Broccoli = false;
            Assert.False(gO.Broccoli);
            gO.Broccoli = true;
            Assert.True(gO.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();
            gO.Mushrooms = false;
            Assert.False(gO.Mushrooms);
            gO.Mushrooms = true;
            Assert.True(gO.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();
            gO.Tomato = false;
            Assert.False(gO.Tomato);
            gO.Tomato = true;
            Assert.True(gO.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();
            gO.Cheddar = false;
            Assert.False(gO.Cheddar);
            gO.Cheddar = true;
            Assert.True(gO.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();
            Assert.Equal("4.57", gO.Price.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();
            Assert.Equal("404", gO.Calories.ToString());
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();
            gO.Broccoli = includeBroccoli;
            gO.Mushrooms = includeMushrooms;
            gO.Tomato = includeTomato;
            gO.Cheddar = includeCheddar;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", gO.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", gO.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", gO.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", gO.SpecialInstructions);
            else Assert.Empty(gO.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();
            Assert.Equal("Garden Orc Omlette", gO.ToString());
        }

        [Fact]
        public void ChangingBroccoliNotifiesIceProperty()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();

            Assert.PropertyChanged(gO, "Broccoli", () =>
            {
                gO.Broccoli = true;
            });

            Assert.PropertyChanged(gO, "Broccoli", () =>
            {
                gO.Broccoli = false;
            });
        }

        [Fact]
        public void ChangingMushroomsNotifiesIceProperty()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();

            Assert.PropertyChanged(gO, "Mushrooms", () =>
            {
                gO.Mushrooms = true;
            });

            Assert.PropertyChanged(gO, "Mushrooms", () =>
            {
                gO.Mushrooms = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesIceProperty()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();

            Assert.PropertyChanged(gO, "Tomato", () =>
            {
                gO.Tomato = true;
            });

            Assert.PropertyChanged(gO, "Tomato", () =>
            {
                gO.Tomato = false;
            });
        }

        [Fact]
        public void ChangingCheddarNotifiesIceProperty()
        {
            GardenOrcOmlette gO = new GardenOrcOmlette();

            Assert.PropertyChanged(gO, "Cheddar", () =>
            {
                gO.Cheddar = true;
            });

            Assert.PropertyChanged(gO, "Cheddar", () =>
            {
                gO.Cheddar = false;
            });
        }
    }
}