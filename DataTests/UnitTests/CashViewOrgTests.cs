/*
 * Author: Elliot Peters
 * Class: CashViewOrgTests.cs
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using Xunit;
using System.ComponentModel;
using System.Collections;
using System.Collections.ObjectModel;
using Xunit.Sdk;
using PointOfSale;
using PointOfSale.RegisterItems;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class CashViewOrgTests
    {
        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            CashViewOrginization cashDrawer = new CashViewOrginization(0);
            cashDrawer.ResetDrawer();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cashDrawer);
        }

        [Fact]
        public void DefaultsShouldBeZeroForCurrencies()
        {
            CashViewOrginization cashDrawer = new CashViewOrginization(0);
            cashDrawer.ResetDrawer();
            Assert.Equal(0, cashDrawer.CurrentPayment);
            Assert.Equal(0, cashDrawer.ChangeDue);
            Assert.Equal(0, cashDrawer.AmountDue);
            Assert.Equal(0, cashDrawer.CusPennies);
            Assert.Equal(0, cashDrawer.CusFiveCents);
            Assert.Equal(0, cashDrawer.CusTenCents);
            Assert.Equal(0, cashDrawer.CusTwentyFiveCents);
            Assert.Equal(0, cashDrawer.CusFiftyCents);
            Assert.Equal(0, cashDrawer.CusOneCoins);
            Assert.Equal(0, cashDrawer.CusOnes);
            Assert.Equal(0, cashDrawer.CusTwos);
            Assert.Equal(0, cashDrawer.CusFives);
            Assert.Equal(0, cashDrawer.CusTens);
            Assert.Equal(0, cashDrawer.CusTwenties);
            Assert.Equal(0, cashDrawer.CusFifties);
            Assert.Equal(0, cashDrawer.CusHundreds);
            Assert.Equal(0, cashDrawer.ChangePennies);
            Assert.Equal(0, cashDrawer.ChangeFiveCents);
            Assert.Equal(0, cashDrawer.ChangeTenCents);
            Assert.Equal(0, cashDrawer.ChangeTwentyFiveCents);
            Assert.Equal(0, cashDrawer.ChangeFiftyCents);
            Assert.Equal(0, cashDrawer.ChangeOneCoins);
            Assert.Equal(0, cashDrawer.ChangeOnes);
            Assert.Equal(0, cashDrawer.ChangeTwos);
            Assert.Equal(0, cashDrawer.ChangeFives);
            Assert.Equal(0, cashDrawer.ChangeTens);
            Assert.Equal(0, cashDrawer.ChangeTwenties);
            Assert.Equal(0, cashDrawer.ChangeFifties);
            Assert.Equal(0, cashDrawer.ChangeHundreds);
            Assert.Equal(474, cashDrawer.Total);
        }

        [Fact]
        public void DefaultsZeroForTotalCostAndPayment()
        {
            CashViewOrginization cashDrawer = new CashViewOrginization(0);
            cashDrawer.ResetDrawer();
            Assert.Equal(0, cashDrawer.TotalCost);
            Assert.True(cashDrawer.UsingEnoughMoney);
            cashDrawer.TotalCost = 1;
            Assert.Equal(1, cashDrawer.TotalCost);
            Assert.False(cashDrawer.UsingEnoughMoney);
        }

        [Fact]
        public void CashDrawerShouldCalculateChange_WithoutSufficientPayment()
        {
            CashViewOrginization cashDrawer = new CashViewOrginization(0);
            cashDrawer.ResetDrawer();
            cashDrawer.OpenDrawer();
            cashDrawer.CusFifties = 1;
            cashDrawer.CusTwenties = 1;
            cashDrawer.CusTens = 3;
            cashDrawer.CusFives = 1;
            cashDrawer.CusTwos = 1;
            cashDrawer.CusOnes = 1;
            cashDrawer.CusOneCoins = 1;
            cashDrawer.CusFiftyCents = 1;
            cashDrawer.CusTwentyFiveCents = 1;
            cashDrawer.CusTenCents = 1;
            cashDrawer.CusFiveCents = 1;
            cashDrawer.CusPennies = 1;
            cashDrawer.TotalCost = 175.23;
            cashDrawer.MakeChange();
            Assert.Equal(0, cashDrawer.ChangeDue);
            Assert.Equal(3, cashDrawer.CusTens);
            Assert.Equal(0, cashDrawer.ChangePennies);
            Assert.Equal(0, cashDrawer.ChangeFiveCents);
            Assert.Equal(0, cashDrawer.ChangeTenCents);
            Assert.Equal(0, cashDrawer.ChangeTwentyFiveCents);
            Assert.Equal(0, cashDrawer.ChangeFiftyCents);
            Assert.Equal(0, cashDrawer.ChangeOneCoins);
            Assert.Equal(0, cashDrawer.ChangeOnes);
            Assert.Equal(0, cashDrawer.ChangeTwos);
            Assert.Equal(0, cashDrawer.ChangeFives);
            Assert.Equal(0, cashDrawer.ChangeTens);
            Assert.Equal(0, cashDrawer.ChangeTwenties);
            Assert.Equal(0, cashDrawer.ChangeFifties);
            Assert.Equal(0, cashDrawer.ChangeHundreds);
        }
        }  
    }