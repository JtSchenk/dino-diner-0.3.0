/*
 * DinoNuggets.cs
 * Author: Jacob Schenkelberg
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree, IMenuItem
    {
        /// <summary>
        /// Variable that represents how many extra nuggets have been added.
        /// </summary>
        private uint extranugget = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// public variable that shows how many ingredients there are. EX: how many chicken nuggets there are.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
                for (int i = 0; i <= extranugget; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// This initiliazes the Nuggets to have a price of 4.25 and calories to 354.
        /// </summary>
        public DinoNuggets()
        {
            this.Calories = 354;
            this.Price = 4.25;
            
        }

        /// <summary>
        /// Method for adding a nugget if the user wants x amount of nuggets.
        /// </summary>
        public void AddNugget()
        {
            extranugget++;
            this.Calories = Calories + 59;
            this.Price = Price + 0.25;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Price");
        }

        public override string ToString()
        {
            return "Dino-Nuggets";
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
                if (extranugget > 0) special.Add(extranugget + " Extra Nuggets");
                return special.ToArray();
            }
        }
    }


}
