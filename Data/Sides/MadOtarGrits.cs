/*
 * Author: Elliot Peters
 * MadOtarGrits.cs
 * Purpose: To build a class for the MOG side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side
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
                if (Size == Size.Large) return 1.93;
                if (Size == Size.Medium) return 1.58;
                if (Size == Size.Small) return 1.22;
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
                if (Size == Size.Large) return 179;
                if (Size == Size.Medium) return 142;
                if (Size == Size.Small) return 105;
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
            return $"{Size} Mad Otar Grits";
        }

    }
}
