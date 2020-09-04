/*
 * Author: Elliot Peters
 * DoubleDraugr.cs
 * Purpose: To build a class for the DD order
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
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
        /// variable for lloking at bool for Ketchup
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// get and set for Ketchup
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set => ketchup = value;
        }

        /// <summary>
        /// variable for lloking at bool for Bun
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// get and set for Bun
        /// </summary>
        public bool Bun
        {
            get => bun;
            set => bun = value;
        }

        /// <summary>
        /// variable for lloking at bool for Mustard
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// get and set for Mustard
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set => mustard = value;
        }


        /// <summary>
        /// variable for lloking at bool for Pickle
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// get and set for Pickle
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set => pickle = value;
        }

        /// <summary>
        /// variable for lloking at bool for Cheese
        /// </summary>
        private bool cheese = true;
        /// <summary>
        /// get and set for cheese
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set => cheese = value;
        }

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
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!cheese) instructions.Add("Hold cheese");
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
