/*
 * Author: Elliot Peters
 * BrairheartBurger.cs
 * Purpose: To build a class for the BB order
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class BriarheartBurger
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 6.32;

        /// <summary>
        /// Gets the value of calories for burger
        /// </summary>
        public uint Calories => 743;

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
        /// Sets up and returns the special instructions list for the burger
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
                return instructions;
            }
        }

        /// <summary>
        /// Method to override the to string for the burger
        /// </summary>
        /// <returns>the correct return that we want</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
