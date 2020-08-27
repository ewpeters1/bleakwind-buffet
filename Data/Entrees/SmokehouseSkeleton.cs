using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the price of the DD burger
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// Gets the value of calories for DD burger
        /// </summary>
        public uint Calories => 602;

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
            set => sausageLink = value;
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
            set => egg = value;
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
            set => hashBrowns = value;
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
            set => pancake = value;
        }

        /// <summary>
        /// Sets up and returns the special instructions list for the DD burger
        /// </summary>
        public List<string> SpecialInstructions
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
        /// Method to override the to string for the DD burger
        /// </summary>
        /// <returns>the correct return that we want</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
