/*
 * Elliot Peters
 * SelEventHandler.cs
 * Creates a class that inherits the events arguments and creates an inumerable based off of the data in the project.
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Creates inumerable, inherits event calss in xaml
    /// </summary>
    public class SelEventHandler : EventArgs
    {
        public IOrderItem item;
    }
}
