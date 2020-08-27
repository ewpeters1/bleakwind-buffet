using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class GardenOrcOmlette
    {
        /// <summary>
        /// Gets the price of the DD burger
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// Gets the value of calories for DD burger
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// variable for looking at bool for broccoli
        /// </summary>
        private bool broccoli = true;
        /// <summary>
        /// get and set for Broccoli
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;
            set => broccoli = value;
        }

        /// <summary>
        /// variable for looking at bool for mushrooms
        /// </summary>
        private bool mushrooms = true;
        /// <summary>
        /// get and set for Mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set => mushrooms = value;
        }

        /// <summary>
        /// variable for looking at bool for a Tomato
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// get and set for a Tomato
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set => tomato = value;
        }

        /// <summary>
        /// variable for looking at bool cheddar
        /// </summary>
        private bool cheddar = true;
        /// <summary>
        /// get and set for cheddar
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set => cheddar = value;
        }

        /// <summary>
        /// Sets up and returns the special instructions list for the DD burger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Method to override the to string for the DD burger
        /// </summary>
        /// <returns>the correct return that we want</returns>
        public override string ToString()
        {
            return "Garden Orc Omlette";
        }
    }
}
