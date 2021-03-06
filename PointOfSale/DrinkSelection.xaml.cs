﻿using System;
using DinoDiner.Menu;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }

        void SelectFlavor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        private void DrinkSelected(object sender, RoutedEventArgs arg)
        {
            if (sender.Equals(Sodasaurus))
            {
                Decaf.Visibility = Visibility.Collapsed;
                Lemon.Visibility = Visibility.Visible;
            }

            if (sender.Equals(Tyrannotea))
            {
                Decaf.Visibility = Visibility.Collapsed;
                Lemon.Visibility = Visibility.Visible;
            }
            if (sender.Equals(JurassicJava))
            {
                Lemon.Visibility = Visibility.Collapsed;
                Decaf.Visibility = Visibility.Visible;
            }
            if (sender.Equals(Water))
            {
                Decaf.Visibility = Visibility.Collapsed;
                Lemon.Visibility = Visibility.Visible;
            }
        }
    }
}
