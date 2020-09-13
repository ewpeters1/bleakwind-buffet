/*
 * Author: Elliot Peters
 * FriedMiraak.cs
 * Purpose: To build a class for the miraak side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak : Side
    {
        private Size size = Size.Small;

        /// <summary>
        /// The property for Price, and returns a value based on the size
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Throws when an invalid size is entered
        /// </exception>
        public override double Price
        {
            get
            {
                if (Size == Size.Large) return 2.88;
                if (Size == Size.Medium) return 2.01;
                if (Size == Size.Small) return 1.78;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// property for calories, and returns based on size
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// Throws when an invalid size is entered
        /// </exception>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Large) return 306;
                if (Size == Size.Medium) return 236;
                if (Size == Size.Small) return 151;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// returns an empty list since there are no special instructions
        /// </summary>
        public override List<string> SpecialInstructions
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
            return $"{Size} Fried Miraak";
        }
    }
}
