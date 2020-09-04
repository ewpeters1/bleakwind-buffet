/*
 * Author: Elliot Peters
 * CandlehearthCoffee.cs
 * Purpose: To build a class for the CHC order
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
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
                if (Size == Size.Large) return 1.75;
                if (Size == Size.Medium) return 1.25;
                if (Size == Size.Small) return 0.75;
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
                if (Size == Size.Large) return 20;
                if (Size == Size.Medium) return 10;
                if (Size == Size.Small) return 7;
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
        /// variable for looking at bool for ice
        /// </summary>
        private bool roomForcream = false;
        /// <summary>
        /// get and set for Ice
        /// </summary>
        public bool RoomForCream
        {
            get => roomForcream;
            set => roomForcream = value;
        }


        /// <summary>
        /// variable for looking at bool for ice
        /// </summary>
        private bool decaf = false;
        /// <summary>
        /// get and set for Ice
        /// </summary>
        public bool Decaf 
        {
            get => decaf;
            set => decaf = value;
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
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the to string method to return what is wanted
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (!Decaf) return $"{Size} Candlehearth Coffee";
            else return $"{Size} Decaf Candlehearth Coffee";
        }
    }
}
