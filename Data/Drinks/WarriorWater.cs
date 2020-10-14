/*
 * Author: Elliot Peters
 * WarriorWater.cs
 * Purpose: To build a class for the WW order
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink 
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
                if (Size == Size.Large) return 0.00;
                if (Size == Size.Medium) return 0.00;
                if (Size == Size.Small) return 0.00;
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
                if (Size == Size.Large) return 0;
                if (Size == Size.Medium) return 0;
                if (Size == Size.Small) return 0;
                throw new NotImplementedException();
            }
        }


        /// <summary>
        /// variable for looking at bool for ice
        /// </summary>
        private bool ice = true;
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
        private bool lemon = false;
        /// <summary>
        /// get and set for Ice
        /// </summary>
        public bool Lemon
        {
            get => lemon;
            set
            {
                lemon = value;
                InvokePropertyChanged("Lemon");
                InvokePropertyChanged("SpecialInstructions");
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
                if (!Ice)
                {
                    instructions.Add("Hold ice");
                }
                if (Lemon)
                {
                    instructions.Add("Add lemon");
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
            return $"{Size} Warrior Water";
        }
    }
}
