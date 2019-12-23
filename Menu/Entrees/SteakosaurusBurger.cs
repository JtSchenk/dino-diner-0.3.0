/*
 * SteakosaurusBurger.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree, IMenuItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Variable the sets the wholewheatbun to true.
        /// </summary>
        private bool wholewheatbun = true;
        /// <summary>
        /// Variable that sets the pickle to be true.
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Variable that sets the ketchup to be true.
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Variable that sets the mustard to be true.
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// This method initiliazes the calories, price, and ingredients for the SteaksaurusBurger.
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Pickle");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
        }

        /// <summary>
        /// This method holds the bun if desired.
        /// </summary>
        public void HoldBun()
        {
            this.wholewheatbun = false;
            ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// This method holds the pickle if desired.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            ingredients.Remove("Pickle");
            NotifyOfPropertyChange("Special");
        }
         
        /// <summary>
        /// This method holds the ketchup if desired.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            ingredients.Remove("Ketchup");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// This method holds the mustard if desired.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            ingredients.Remove("Mustard");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Overrides the ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }

        /// <summary>
        /// Overrides Ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>
                {
                    "Steakburger Pattie"
                };
                if (wholewheatbun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
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
                if (!wholewheatbun) special.Add("Hold Whole Wheat Bun");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                return special.ToArray();
            }
        }
    }
}
