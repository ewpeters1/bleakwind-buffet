/*
 * Author: Elliot Peters
 * DragonbornWaffles.cs
 * Purpose: To build a class for the Dragonborn side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        private Size size = Size.Small;

        /// <summary>
        /// This is the size property, and has get and set
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// The property for Price, and returns a value based on the size
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Throws when an invalid size is entered
        /// </exception>
        public double Price
        {
            get
            {
                if (Size == Size.Large) return 0.96;
                if (Size == Size.Medium) return 0.76;
                if (Size == Size.Small) return 0.42;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// property for calories, and returns based on size
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Throws when an invalid size is entered
        /// </exception>
        public uint Calories
        {
            get
            {
                if (Size == Size.Large) return 100;
                if (Size == Size.Medium) return 89;
                if (Size == Size.Small) return 77;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// returns an empty list since there are no special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the to string method to return what is wanted
        /// </summary>
        /// <returns>The correct ToString</returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
