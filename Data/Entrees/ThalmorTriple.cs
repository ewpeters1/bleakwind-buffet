/*
 * Author: Elliot Peters
 * ThalmorTriple.cs
 * Purpose: To build a class for the TT order
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple : Entree
    {
        /// <summary>
        /// Gets the price of the TT
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// Gets the value of calories for DD burger
        /// </summary>
        public override uint Calories => 943;

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
        public override List<string> SpecialInstructions
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
