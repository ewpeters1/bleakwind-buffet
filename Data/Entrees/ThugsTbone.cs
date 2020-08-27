﻿/*
 * Author: Elliot Peters
 * ThugsTbone.cs
 * Purpose: To build a class for the TT order
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class ThugsTbone
    {
        /// <summary>
        /// Price for Thugs Tbone
        /// </summary>
        public double Price = 6.44;

        /// <summary>
        /// uint for calorie values
        /// </summary>
        public uint Calories = 982;

        /// <summary>
        /// Returns an empty list for the special instructions for the T-bone
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
        /// Method to override the to string for the Tbone
        /// </summary>
        /// <returns>the correct return that we want</returns>
        public override string ToString()
        {
            return "Thugs T-bone";
        }


    }
}
