/*
 * Author: ELliot Peters
 * Title: Entree.cs
 * Purpose: Used as base file for entrees
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
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
