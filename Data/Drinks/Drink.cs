/*
 * Author: Elliot Peters
 * Title: Drink.cs
 * Purpose: Used as base file for drinks
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing common properties of drinks 
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {

        protected Size size = Size.Small;

        public virtual event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This is a method to simplify the calling process if Invoking a property
        /// </summary>
        /// <param name="name">the name of the invoked</param>
        protected void InvokePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// Size of drink
        /// </summary>
        public virtual Size Size 
        {
            get => size;
            set
            {
                size = value;
                InvokePropertyChanged("Size");
                InvokePropertyChanged("Price");
                InvokePropertyChanged("Calories");
                InvokePropertyChanged("TrueString");
                InvokePropertyChanged("Flavor");
            }
        }

        /// <summary>
        /// Price of drink
        /// </summary>
        /// <value>
        /// US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// Allows for better display in xaml for true string
        /// </summary>
        public virtual string TrueString
        {
            get
            {
                return this.ToString();
            }
        }


        /// <summary>
        /// Calories for drinks
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the drink 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
