using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    public class SailorsSoda
    {
        Size size1 = Size.Small;

        public double Price;

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




    }
}
