using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    public class WarriorWater
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
                if (Size == Size.Large) return 0.00;
                if (Size == Size.Medium) return 0.00;
                if (Size == Size.Small) return 0.00;
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
                if (Size == Size.Large) return 0;
                if (Size == Size.Medium) return 0;
                if (Size == Size.Small) return 0;
                throw new NotImplementedException();
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
            set => ice = value;
        }


        /// <summary>
        /// variable for looking at bool for ice
        /// </summary>
        private bool lemon = false;
        /// <summary>
        /// get and set for Ice
        /// </summary>
        public bool Lemon
        {
            get => lemon;
            set => lemon = value;
        }

        /// <summary>
        /// Sets up and returns the special instructions list for the juice
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the to string method to return what is wanted
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
    }
}
