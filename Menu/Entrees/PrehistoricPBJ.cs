/*
 * PrehistoricPBJ.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree, IMenuItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// sets the peanutButter boolean to be true
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// Sets the jelly boolean to be true
        /// </summary>
        private bool jelly = true;

        /// <summary>
        /// Method that initializes the calories, price, and ingredients for the prehistoric PBG.
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
            ingredients.Add("Bread");
            ingredients.Add("Peanut Butter");
            ingredients.Add("Jelly");
        }

        /// <summary>
        /// Method that removes the Peanut Butter if desired.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            ingredients.Remove("Peanut Butter");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method that removes the Jelly if desired.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            ingredients.Remove("Jelly");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Overrides the ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        /// <summary>
        /// Overrides Ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
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
                if (peanutButter == false) special.Add("Hold Peanut Butter");
                if (jelly == false) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }
    }
}
