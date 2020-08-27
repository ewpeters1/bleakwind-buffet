/*
 * Author: Elliot Peters
 * ThalmorTriple.cs
 * Purpose: To build a class for the TT order
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class ThalmorTriple
    {
        /// <summary>
        /// Gets the price of the TT
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// Gets the value of calories for DD burger
        /// </summary>
        public uint Calories => 943;

        /// <summary>
        /// variable for looking at bool for bacon
        /// </summary>
        private bool bacon = true;
        /// <summary>
        /// get and set for Tomato
        /// </summary>
        public bool Bacon
        {
            get => bacon;
            set => bacon = value;
        }

        /// <summary>
        /// variable for lloking at bool for egg
        /// </summary>
        private bool egg = true;
        /// <summary>
        /// get and set for Egg
        /// </summary>
        public bool Egg
        {
            get => egg;
            set => egg = value;
        }

        /// <summary>
        /// Sets up and returns the special instructions list for the TT
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }

        /// <summary>
        /// Method to override the to string for theTT
        /// </summary>
        /// <returns>the correct return that we want</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
