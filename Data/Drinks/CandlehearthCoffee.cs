/*
 * Author: Elliot Peters
 * CandlehearthCoffee.cs
 * Purpose: To build a class for the CHC order
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink 
    {


        /// <summary>
        /// The property for Price, and returns a value based on the size
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Throws when an invalid size is entered
        /// </exception>
        public override double Price
        {
            get
            {
                if (Size == Size.Large)
                {
                    return 1.75;
                }
                if (Size == Size.Medium) return 1.25;
                if (Size == Size.Small) return 0.75;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// property for calories, and returns based on size
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Throws when an invalid size is entered
        /// </exception>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Large) return 20;
                if (Size == Size.Medium) return 10;
                if (Size == Size.Small) return 7;
                throw new NotImplementedException();
            }
        }


        /// <summary>
        /// variable for looking at bool for ice
        /// </summary>
        private bool ice = false;
        /// <summary>
        /// get and set for Ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set
            {
                ice = value;
                InvokePropertyChanged("Ice");
                InvokePropertyChanged("SpecialInstructions");
            }
        }


        /// <summary>
        /// variable for looking at bool for ice
        /// </summary>
        private bool roomForcream = false;
        /// <summary>
        /// get and set for Ice
        /// </summary>
        public bool RoomForCream
        {
            get => roomForcream;
            set
            {
                roomForcream = value;
                InvokePropertyChanged("RoomForCream");
                InvokePropertyChanged("SpecialInstructions");
            }
        }


        /// <summary>
        /// variable for looking at bool for ice
        /// </summary>
        private bool decaf = false;
        /// <summary>
        /// get and set for Ice
        /// </summary>
        public bool Decaf 
        {
            get => decaf;
            set
            {
                decaf = value;
                InvokePropertyChanged("Decaf");
            }
        }

        /// <summary>
        /// Sets up and returns the special instructions list for the juice
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice)
                {
                    instructions.Add("Add ice");
                }
                if (RoomForCream) 
                { 
                    instructions.Add("Add cream");
                }
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the to string method to return what is wanted
        /// </summary>
        /// <returns>The correct ToString</returns>
        public override string ToString()
        {
            if (!Decaf) return $"{Size} Candlehearth Coffee";
            else return $"{Size} Decaf Candlehearth Coffee";
        }
    }
}
