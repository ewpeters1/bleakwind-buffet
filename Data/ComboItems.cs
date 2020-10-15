/*
 * Elliot Peters
 * ComboTests.cs
 * Used for making combos of different items
 */
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// class representing and combo of Entree drink or side.
    /// </summary>
    public class ComboItems : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This is a method to simplify the calling process if Invoking a property
        /// </summary>
        /// <param name="name">the name of the invoked</param>
        protected void InvokePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private Entree entree;

        /// <summary>
        /// Entree property for the combo class
        /// </summary>
        public Entree Entree
        {
            get => entree;
            set
            {
                entree = value;
                InvokePropertyChanged("Entree");
                InvokePropertyChanged("Price");
                InvokePropertyChanged("Calories");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Private variable for drink
        /// </summary>
        private Drink drink;

        /// <summary>
        /// Drink property for the combo class
        /// </summary>
        public Drink Drink
        {
            get => drink;
            set
            {
                drink = value;
                InvokePropertyChanged("Drink");
                InvokePropertyChanged("Price");
                InvokePropertyChanged("Calories");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// private side variable
        /// </summary>
        private Side side;

        /// <summary>
        /// Side property for the combo class
        /// </summary>
        public Side Side
        {
            get => side;
            set
            {
                side = value;
                InvokePropertyChanged("Side");
                InvokePropertyChanged("Price");
                InvokePropertyChanged("Calories");
                InvokePropertyChanged("SpecialInstructions");
            }
        }


        /// <summary>
        /// Price calculation for the combo
        /// </summary>
        public double Price
        {
            get
            {
                double priceVal = 0;
                if(Entree != null)
                {
                    priceVal += Entree.Price;
                }
                if (Drink != null)
                {
                    priceVal += Drink.Price;
                }
                if (Side != null)
                {
                    priceVal += Side.Price;
                }
                return priceVal - 1.0;
            }
        }

        /// <summary>
        /// Calories calulation for the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calVal = 0;
                if(Entree != null)
                {
                    calVal += Entree.Calories;
                }
                if (Drink != null)
                {
                    calVal += Drink.Calories;
                }
                if (Side != null)
                {
                    calVal += Side.Calories;
                }
                return calVal;
            }
        }

        /// <summary>
        /// This is the SpecialInstructions method for the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();
                if (Entree != null)
                {
                    si.Add(Entree.ToString() + Environment.NewLine);
                    si.Add(Entree.SpecialInstructions.ToString() + Environment.NewLine);
                }
                if (Drink != null)
                {
                    si.Add(Drink.ToString() + Environment.NewLine);
                    si.Add(Drink.SpecialInstructions.ToString() + Environment.NewLine);
                }
                if (Side != null)
                {
                    si.Add(Side.SpecialInstructions.ToString());
                }
                return si;
            }
        }
    }
}
