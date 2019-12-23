/*
 * VelociWrap.cs
 * Author: Jacob Schenkelberg
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class VelociWrap : Entree, IMenuItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Sets the dressing to be true.
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// Sets the lettuce to be true.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Sets the cheese to be true.
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// Method that initiliazes the Price, Calories, and ingredients for the VelociWrap.
        /// </summary>
        public VelociWrap()
        {
            this.Calories = 356;
            this.Price = 6.86;
            ingredients.Add("Flour Tortilla");
            ingredients.Add("Chicken Breast");
            ingredients.Add("Ceasar Dressing");
            ingredients.Add("Romaine Lettuce");
            ingredients.Add("Parmesan Cheese");
        }

        /// <summary>
        /// Method that holds the Dressing if desired.
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            ingredients.Remove("Ceasar Dressing");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method that holds the lettuce if desired.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            ingredients.Remove("Romaine Lettuce");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method that holds the cheese if desired.
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            ingredients.Remove("Parmesan Cheese");
            NotifyOfPropertyChange("Special");
        }

        public override string ToString()
        {
            return "Veloci-Wrap";
        }

        /// <summary>
        /// Overrides Ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>()
                {
                    "Flour Tortilla",
                    "Chicken Breast",
                };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
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
                if (!lettuce) special.Add("Hold Romaine Lettuce");
                if (!dressing) special.Add("Hold Caesar Dressing");
                if (!cheese) special.Add("Hold Parmesan Cheese");
                return special.ToArray();
            }
        }

    }
}
