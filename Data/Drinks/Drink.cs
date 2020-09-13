using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing common properties of drinks 
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Size of drink
        /// </summary>
        public virtual Size Size { get; set; }

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
