﻿/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// These are the tests for The Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(ss);
        }
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Egg = false;
            Assert.False(ss.Egg);
            ss.Egg = true;
            Assert.True(ss.Egg);

        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = false;
            Assert.False(ss.Pancake);
            ss.Pancake = true;
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("5.62", ss.Price.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("602", ss.Calories.ToString());
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = includeSausage;
            ss.Egg = includeEgg;
            ss.HashBrowns = includeHashbrowns;
            ss.Pancake = includePancake;
            if (!includeSausage) Assert.Contains("Hold sausage", ss.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold eggs", ss.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", ss.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancakes", ss.SpecialInstructions);
            else Assert.Empty(ss.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ss.ToString());
        }


        [Fact]
        public void ChangingSausageNotifiesProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "SausageLink", () =>
            {
                ss.SausageLink = true;
            });

            Assert.PropertyChanged(ss, "SausageLink", () =>
            {
                ss.SausageLink = false;
            });
        }


        [Fact]
        public void ChangingHashBrownsNotifiesProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "HashBrowns", () =>
            {
                ss.HashBrowns = true;
            });

            Assert.PropertyChanged(ss, "HashBrowns", () =>
            {
                ss.HashBrowns = false;
            });
        } 

        [Fact]
        public void ChangingEggNotifiesProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "Egg", () =>
            {
                ss.Egg = true;
            });

            Assert.PropertyChanged(ss, "Egg", () =>
            {
                ss.Egg = false;
            });
        }

        [Fact]
        public void ChangingPancakeNotifiesProperty()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "Pancake", () =>
            {
                ss.Pancake = true;
            });

            Assert.PropertyChanged(ss, "Pancake", () =>
            {
                ss.Pancake = false;
            });
        }

        [Fact]
        public void InheritsInterface()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ss);
        }

        [Theory]
        [InlineData("Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.")]
        public void ShouldReturnCorrectDescription(string s)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(s, ss.Description);
        }
    }
}