/*
 * Author: Elliot Peters
 * Title: IOrderItem.cs
 * Purpose: To act as interface for menu
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface representing properties of items being ordered
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets price of item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// gets calories of item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Description of item
        /// </summary>
        string Description { get; }
        
        /// <summary>
        /// Gets soecial instruction list of item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
