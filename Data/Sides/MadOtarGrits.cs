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
    public class MadOtarGrits
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
        public double Price
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
        public uint Calories
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
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }

    }
}
