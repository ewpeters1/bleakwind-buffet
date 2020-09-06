/*
 * Author: Elliot Peters
 * AretinoAppleJuice.cs
 * Purpose: To build a class for the apple juice order
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
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
                if (Size == Size.Large) return 1.01;
                if (Size == Size.Medium) return 0.87;
                if (Size == Size.Small) return 0.62;
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
                if (Size == Size.Large) return 132;
                if (Size == Size.Medium) return 88;
                if (Size == Size.Small) return 44;
                throw new NotImplementedException();
            }
        }


        /// <summary>
        /// variable for looking at bool for ice
        /// </summary>
        private bool ice = false;
        /// <summary>
        /// get and set for Ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set => ice = value;
        }

        /// <summary>
        /// Sets up and returns the special instructions list for the juice
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the to string method to return what is wanted
        /// </summary>
        /// <returns>The correct ToString</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }
    }
}
