/*
 * Author: Elliot Peters
 * MarkarthMilk.cs
 * Purpose: To build a class for the MM order
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk : Drink 
    {
        private Size size = Size.Small;

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
                if (Size == Size.Large) return 1.22;
                if (Size == Size.Medium) return 1.11;
                if (Size == Size.Small) return 1.05;
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
                if (Size == Size.Large) return 93;
                if (Size == Size.Medium) return 72;
                if (Size == Size.Small) return 56;
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
            }
        }

        /// <summary>
        /// Sets up and returns the special instructions list for the Milk
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the to string method to return what is wanted
        /// </summary>
        /// <returns>The correct ToString</returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk"; 
        }
    }
}
