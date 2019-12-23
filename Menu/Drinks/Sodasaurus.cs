/*
 * Sodasaurus.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink, IMenuItem, INotifyPropertyChanged
    {
        public override event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool Ice = true;

        /// <summary>
        /// Private backing variable for flavor
        /// </summary>
        private SodasaurusFlavor flavor;
        /// <summary>
        /// Gets and sets the flavor.
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Private backing variable size.
        /// </summary>
        private Size size;

        /// <summary>
        /// This checks and sets the size equal to small, medium, or large and gives them
        /// a Price & Calories value.
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
                size = value;
                // set the prices for small and large
                if (size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }
                else if (size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                }
                else if (size == Size.Large)
                {
                    Price = 2.50;
                    Calories = 208;
                }
            }
        }

        /// <summary>
        /// Initiliazes the Sodasaurus class to have a default Price, Calories, and ingredients.
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }

        public void HoldIce()
        {
            NotifyOfPropertyChange("Special");
            Ice = false;
        }

        /// <summary>
        /// Overrides the ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size + " " + flavor + " Sodasaurus";
        }

        /// <summary>
        /// Overrides Ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
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
                if (Ice == false) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
    }
}