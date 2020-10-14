/*
 * Author: Elliot Peters
 * PhillyPoacher.cs
 * Purpose: To build a class for the PP order
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree
    {
        /// <summary>
        /// Gets the price of the Poacher
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        /// Gets the value of calories for Poacher
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// variable for looking at bool for sirloin
        /// </summary>
        private bool sirloin = true;
        /// <summary>
        /// get and set for Sirloin
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;
            set
            {
                sirloin = value;
                InvokePropertyChanged("Sirloin");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// variable for looking at bool for onion
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// get and set for Onion
        /// </summary>
        public bool Onion
        {
            get => onion;
            set
            {
                onion = value;
                InvokePropertyChanged("Onion");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// variable for looking at bool for roll
        /// </summary>
        private bool roll = true;
        /// <summary>
        /// get and set for Roll
        /// </summary>
        public bool Roll
        {
            get => roll;
            set
            {
                roll = value;
                InvokePropertyChanged("Roll");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Sets up and returns the special instructions list for the Philly Poacher
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin)
                {
                    instructions.Add("Hold sirloin");

                }
                if (!Onion)
                {
                    instructions.Add("Hold onions");

                }
                if (!Roll)
                {
                    instructions.Add("Hold roll");
                }
                return instructions;
            }
        }

        /// <summary>
        /// Method to override the to string for the Poacher
        /// </summary>
        /// <returns>the correct return that we want</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
