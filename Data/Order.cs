/*
 * Elliot Peters
 * Order.cs
 * Defines an order class
 */
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Collections;
using System.Text;
using System.Transactions;
using System.Xml.Schema;

namespace BleakwindBuffet.Data
{
    public class Order : INotifyPropertyChanged, INotifyCollectionChanged, ICollection
    {
        /// <summary>
        /// Order item
        /// </summary>
        public List<IOrderItem> order;

        /// <summary>
        /// Contructor for the order
        /// </summary>
        public Order()
        {
            order = new List<IOrderItem>();
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

        /// <summary>
        /// Sales tax rate with associated value
        /// </summary>
        private double _salesTaxRate = 0.12;

        /// <summary>
        /// Property for the rate
        /// </summary>
        public double SalesTaxRate
        {
            get => _salesTaxRate;
            set
            {
                _salesTaxRate = value;
            }
        }

        /// <summary>
        /// The order number
        /// </summary>
        public uint Number { get; }

        /// <summary>
        /// The price for the order without tax
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach (IOrderItem item in order)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// The tax for the order
        /// </summary>
        public double Tax { get => (SalesTaxRate * Subtotal); }

        /// <summary>
        /// The total for the ordser including tax
        /// </summary>
        public double Total { get => (Subtotal + Tax); }

        /// <summary>
        /// Property for calories 
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// property for the calorie sum
        /// </summary>
        public uint calorieSum
        {
            get
            {
                uint calSum = 0;
                foreach (IOrderItem item in order)
                {
                    calSum += item.Calories;
                }
                return calSum;
            }
        }

        /// <summary>
        /// Collection property
        /// </summary>
        public int Count => ((ICollection)order).Count;

        /// <summary>
        /// Collection property
        /// </summary>
        public bool IsSynchronized => ((ICollection)order).IsSynchronized;

        /// <summary>
        /// Collection property
        /// </summary>
        public object SyncRoot => ((ICollection)order).SyncRoot;

        /// <summary>
        /// The next order number 
        /// </summary>
        private static uint nextOrderNumber = 1;

        /// <summary>
        /// Event handler for property changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property for the Collection changed
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// This is a method to simplify the calling process if Invoking a property
        /// </summary>
        /// <param name="name">the name of the invoked</param>
        protected void InvokePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// event listener for the item changing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemChanges(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                InvokePropertyChanged("Subtotal");
                InvokePropertyChanged("Tax");
                InvokePropertyChanged("Total");
            }
            if (e.PropertyName == "Calories") InvokePropertyChanged("Calories");
        }


        /// <summary>
        /// Add method for adding an item to an order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, order.IndexOf(item)));
            order.Add(item);
            InvokePropertyChanged("Subtotal");
            InvokePropertyChanged("Tax");
            InvokePropertyChanged("Total");
            InvokePropertyChanged("Calories");
            item.PropertyChanged += ItemChanges;
        }

        /// <summary>
        /// Remove method for removing an order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, order.IndexOf(item)));
            order.Remove(item);
            InvokePropertyChanged("Subtotal");
            InvokePropertyChanged("Tax");
            InvokePropertyChanged("Total");
            InvokePropertyChanged("Calories");
            item.PropertyChanged -= ItemChanges;
        }

        /// <summary>
        /// This method clears an order
        /// </summary>
        public void Clear()
        {
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            order.Clear();
            InvokePropertyChanged("Subtotal");
            InvokePropertyChanged("Tax");
            InvokePropertyChanged("Total");
            InvokePropertyChanged("Calories");
        }

        /// <summary>
        /// This is a method from ICollection
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        public void CopyTo(Array array, int index)
        {
            ((ICollection)order).CopyTo(array, index);
        }

        /// <summary>
        /// This is the method for GetEnumerator from ICollection
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)order).GetEnumerator();
        }
    } 
}
