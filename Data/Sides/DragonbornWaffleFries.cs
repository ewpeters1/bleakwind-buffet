﻿/*
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
    public class DragonbornWaffleFries : Side
    {

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
        public override uint Calories
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
        /// Description of item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Crispy fried potato waffle fries.";
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
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
