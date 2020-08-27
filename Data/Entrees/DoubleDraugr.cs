/*
 * Author: Elliot Peters
 * DoubleDraugr.cs
 * Purpose: To build a class for the DD order
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class DoubleDraugr
    {
        /// <summary>
        /// Gets the price of the DD burger
        /// </summary>
        public double Price =>7.32;

        /// <summary>
        /// Gets the value of calories for DD burger
        /// </summary>
        public uint Calories => 843;

        /// <summary>
        /// variable for looking at bool for tomato
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// get and set for Tomato
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set => tomato = value;
        }

        /// <summary>
        /// variable for lloking at bool for lettuce
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// get and set for Lettuce
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;
            set => lettuce = value;
        }

        /// <summary>
        /// variable for looking at bool for mayo
        /// </summary>
        private bool mayo = true;
        /// <summary>
        /// get and set for Mayo
        /// </summary>
        public bool Mayo
        {
            get => mayo;
            set => mayo = value;
        }

        /// <summary>
        /// Sets up and returns the special instructions list for the DD burger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
        }

        /// <summary>
        /// Method to override the to string for the DD burger
        /// </summary>
        /// <returns>the correct return that we want</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
