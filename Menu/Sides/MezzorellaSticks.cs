﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class MezzorellaSticks : Side, IMenuItem, INotifyPropertyChanged
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
                            Calories = 540;
                            break;
                        case Size.Medium:
                            Price = 1.45;
                            Calories = 610;
                            break;
                        case Size.Large:
                            Price = 1.95;
                            Calories = 720;
                            break;
                    }
                }
            }

        /// <summary>
        /// This method initiliazes the price, calories, and ingredients for the MezzorellaSticks.
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
            Ingredients.Add("Cheese Product");
            Ingredients.Add("Breading");
            Ingredients.Add("Vegetable Oil");
        }

        public override string ToString()
        {
            return size + " Mezzorella Sticks";
        }

        /// <summary>
        /// Overrides Ingredients
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Cheese Product");
                Ingredients.Add("Breading");
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
