﻿/*
 * Fryceritops.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Fryceritops : Side, IMenuItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Protected variable size inherited from the Size class.
        /// </summary>
        protected Size size;
        /// <summary>
        /// This method gets and returns the size and then sets the cases for if the size is small, medium, or large
        /// and then sets the prices and calories depending on the size.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
        }

        /// <summary>
        /// This method initiliazes the price, calories, and ingredients for the Fryceritops.
        /// </summary>
        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;
            Ingredients.Add("Potato");
            Ingredients.Add("Salt");
            Ingredients.Add("Vegetable Oil");
        }

        /// <summary>
        /// Override ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Friceritops";
        }

        /// <summary>
        /// Gets Ingredients
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Potato");
                Ingredients.Add("Salt");
                Ingredients.Add("Vegetable Oil");
                return Ingredients;
            }
        }

        public override string Description
        {
            get { return this.ToString(); }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }

    }
}
