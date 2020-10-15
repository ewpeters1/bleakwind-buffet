/*
 * Elliot Peters
 * OrderTests.cs
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
namespace BleakwindBuffet.DataTests
{
    public class OrderTests
    {
        [Fact]
        public void AddingEntreeToOrderNotifiesOrderSubtotal()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(bb);
            });
        }
        [Fact]
        public void AddingEntreeToOrderNotifiesOrderTax()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(bb);
            });
        }
        [Fact]
        public void AddingEntreeToOrderNotifiesOrderTotal()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Add(bb);
            });
        }
        [Fact]
        public void AddingEntreeToOrderNotifiesOrderCalories()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(bb);
            });
        }


        [Fact]
        public void RemovingEntreeToOrderNotifiesOrderSubtotal()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(bb);
            });
        }
        [Fact]
        public void RemovingEntreeToOrderNotifiesOrderTax()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Remove(bb);
            });
        }
        [Fact]
        public void removingEntreeToOrderNotifiesOrderTotal()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Remove(bb);
            });
        }
        [Fact]
        public void RemovingEntreeToOrderNotifiesOrderCalories()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Remove(bb);
            });
        }

    }
}
