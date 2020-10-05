/*
 * Author: Elliot Peters
 * SailorSoda.cs
 * Purpose: To build a class for the sailor soda order
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink
    {
        /// <summary>
        /// calue initializing the size to small 
        /// </summary>
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
                if (Size == Size.Large) return 2.07;
                if (Size == Size.Medium) return 1.74;
                if (Size == Size.Small) return 1.42;
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
                if (Size == Size.Large) return 205;
                if (Size == Size.Medium) return 153;
                if (Size == Size.Small) return 117;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// This is the property for the flavor, has get and set methods 
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                flavor = value;
                InvokePropertyChanged("Flavor");
            }
        }


        /// <summary>
        /// variable for looking at bool for ice
        /// </summary>
        private bool ice = true;
        /// <summary>
        /// get and set for Ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set
            {
                ice = value;
                InvokePropertyChanged("Ice");
            }
        }

        /// <summary>
        /// Sets up and returns the special instructions list for the Soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the to string method to return what is wanted
        /// </summary>
        /// <returns>The correct ToString</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }


    }
}
