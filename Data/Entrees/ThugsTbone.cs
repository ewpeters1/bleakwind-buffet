/*
 * Author: Elliot Peters
 * ThugsTbone.cs
 * Purpose: To build a class for the TT order
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTbone : Entree
    {
        /// <summary>
        /// Price for Thugs Tbone
        /// </summary>
        public override double Price => 6.44;

        /// <summary>
        /// uint for calorie values
        /// </summary>
        public override uint Calories => 982;

        /// <summary>
        /// Returns an empty list for the special instructions for the T-bone
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
        /// Method to override the to string for the Tbone
        /// </summary>
        /// <returns>the correct return that we want</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }


    }
}
