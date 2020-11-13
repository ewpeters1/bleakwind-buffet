/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThugsTbone tb = new ThugsTbone();
            Assert.IsAssignableFrom<Entree>(tb);
        }
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTbone tb = new ThugsTbone();
            Assert.Equal("6.44", tb.Price.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTbone tb = new ThugsTbone();
            Assert.Equal("982", tb.Calories.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTbone tb = new ThugsTbone();
            Assert.Empty(tb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTbone tb = new ThugsTbone();
            Assert.Equal("Thugs T-Bone", tb.ToString());
        }

        [Fact]
        public void InheritsInterface()
        {
            ThugsTbone tb = new ThugsTbone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tb);
        }

        [Theory]
        [InlineData("Juicy T-Bone, not much else to say.")]
        public void ShouldReturnCorrectDescription(string s)
        {
            ThugsTbone tb = new ThugsTbone();
            Assert.Equal(s, tb.Description);
        }
    }
}