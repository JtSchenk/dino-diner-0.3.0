﻿/*
 * Brontowurst.cs
 * Author: Jacob Schenkelberg
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    
    public class Brontowurst : Entree, IMenuItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
                if (wholewheatbun == false) special.Add("Hold Whole Wheat Bun");
                if (onions == false) special.Add("Hold Onion");
                if (peppers == false) special.Add("Hold Peppers");
                return special.ToArray();
            }
        }

        // private field that intiliates the bun to be true. Later has a method that can change it to false.
        private bool wholewheatbun = true;

        // private field that intiliates the peppers to be true. Later has a method that can change it to false.
        private bool peppers = true;

        // private field that intiliates the onions to be true. Later has a method that can change it to false.
        private bool onions = true;

        /// <summary>
        /// This method initiliazes the Brontowurst to have the default ingredients, price, and calories
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
            ingredients.Add("Brautwurst");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Peppers");
            ingredients.Add("Onion");
        }

        /// <summary>
        /// Method for removing bun
        /// </summary>
        public void HoldBun()
        {
            this.wholewheatbun = false;
            ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method for removing peppers.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            ingredients.Remove("Peppers");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method for removing onions.
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            ingredients.Remove("Onion");
            NotifyOfPropertyChange("Special");
        }


        public override string ToString()
        {
            return "Brontowurst";
        }

        /// <summary>
        /// Overrides Ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (wholewheatbun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }
    }
}
