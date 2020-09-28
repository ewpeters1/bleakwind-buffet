﻿using System;
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

namespace PointOfSale.Entrees
{
    /// <summary>
    /// Interaction logic for ThalmoreTripleSelection.xaml
    /// </summary>
    public partial class ThalmorTripleSelection : UserControl
    {

        private MenuOverheadControl menuLook = new MenuOverheadControl();

        public ThalmorTripleSelection(MenuOverheadControl menuVal)
        {
            InitializeComponent();
            menuLook = menuVal;
        }
        void BackClick(object sender, RoutedEventArgs e)
        {
            menuLook.menuBorder.Child = menuLook.menuSelect;
        }

    }
}