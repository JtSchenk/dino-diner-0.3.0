/*
 * PterodactylWings.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree, IMenuItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Initiliazes the PterodactlyWings to have a set number of calories, price, and ingredients.
        /// </summary>

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public PterodactylWings()
        {
            this.Calories = 318;
            this.Price = 7.21;
            ingredients.Add("Chicken");
            ingredients.Add("Wing Sauce");
        }

        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

        /// <summary>
        /// Overrides Ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Chicken");
                ingredients.Add("Wing Sauce");
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
                return special.ToArray();
            }
        }

    }
}
