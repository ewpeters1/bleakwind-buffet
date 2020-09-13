using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree
    {

        /// <summary>
        /// Price of drink
        /// </summary>
        /// <value>
        /// US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories for drinks
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the drink 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
