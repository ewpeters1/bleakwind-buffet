/*
 * Author: Elliot Peters
 * SmokehouseSkeleton.cs
 * Purpose: To build a class for the SS order
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree
    {
        /// <summary>
        /// Gets the price of the DD burger
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Gets the value of calories for SS
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// variable for looking at bool for a sausage link
        /// </summary>
        private bool sausageLink = true;
        /// <summary>
        /// get and set for a Sausage Link
        /// </summary>
        public bool SausageLink
        {
            get => sausageLink;
            set
            {
                sausageLink = value;
                InvokePropertyChanged("SausageLink");
            }
        }

        /// <summary>
        /// variable for looking at bool for egg
        /// </summary>
        private bool egg = true;
        /// <summary>
        /// get and set for Egg
        /// </summary>
        public bool Egg
        {
            get => egg;
            set
            {
                egg = value;
                InvokePropertyChanged("Egg");
            }
        }

        /// <summary>
        /// variable for looking at bool for a hash brown
        /// </summary>
        private bool hashBrowns = true;
        /// <summary>
        /// get and set for a HashBrown
        /// </summary>
        public bool HashBrowns
        {
            get => hashBrowns;
            set
            {
                hashBrowns = value;
                InvokePropertyChanged("HashBrowns");
            }
        }

        /// <summary>
        /// variable for looking at bool a pancake
        /// </summary>
        private bool pancake = true;
        /// <summary>
        /// get and set for a pancake
        /// </summary>
        public bool Pancake
        {
            get => pancake;
            set
            {
                pancake = value;
                InvokePropertyChanged("Pancake");
            }
        }

        /// <summary>
        /// Sets up and returns the special instructions list for the SS
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// Method to override the to string for the SS
        /// </summary>
        /// <returns>the correct return that we want</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
