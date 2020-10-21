/*
 * Elliot Peters
 * CurrrencyControl.xaml.cs
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale.RegisterItems
{
    /// <summary>
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        /// <summary>
        /// Dependency property for the customer quantity given
        /// </summary>
        public static DependencyProperty CustomerQuantityProperty = DependencyProperty.Register("CustomerQuantity", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// Change dependecy property
        /// </summary>
        public static DependencyProperty ChangeQuantityProperty = DependencyProperty.Register("ChangeQuantity", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0,FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// This is the constructor 
        /// </summary>
        public CurrencyControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the value connected to CustomerQuantityProperty
        /// </summary>
        public int CustomerQuantity
        {
            get => (int)GetValue(CustomerQuantityProperty);
            set
            {
                SetValue(CustomerQuantityProperty, value);
            }
        }

        /// <summary>
        /// This is the value connected to the ChangeQuantityProperty
        /// </summary>
        public int ChangeQuantity
        {
            get => (int)GetValue(ChangeQuantityProperty);
            set
            {
                SetValue(ChangeQuantityProperty, value);
            }
        }

        /// <summary>
        /// This incrememnts and decrements the values correctly 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                switch (button.Name)
                {
                    case "Increment":
                        if(CustomerQuantity >= 0)
                        {
                            CustomerQuantity++;
                        }
                        break;
                    case "Decrement":
                        if(CustomerQuantity > 0)
                        {
                            CustomerQuantity--;
                        }
                        break;                   
                }
            }
            e.Handled = true;
        }
    }
}
