/*
 * Author: Elliot Peters
 * Title: Side.cs
 * Purpose: Used as base file for entrees
 */
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : IOrderItem, INotifyPropertyChanged
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
            }
        }

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
        /// Description of items
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Price of drink
        /// </summary>
        /// <value>
        /// US Dollars
        /// </value>
        public abstract double Price { get; }

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
