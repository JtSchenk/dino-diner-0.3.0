/*
 * TRexKingBurger.cs
 * Author: Jacob Schenkelberg
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree, IMenuItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Sets the bun to be true.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Sets the lettuce to be true.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Sets the tomato to be true.
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// Sets the onion to be true.
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// Sets the pickle to be true.
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Sets the ketchup to be true.
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Sets the mustard to be true.
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// Sets the mayo to be true.
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// This initilaizes the price, calories, and ingredients for the TRexKingBurger.
        /// </summary>
        public TRexKingBurger()
        {
            this.Calories = 728;
            this.Price = 8.45;
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Lettuce");
            ingredients.Add("Tomato");
            ingredients.Add("Onion");
            ingredients.Add("Pickle");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
            ingredients.Add("Mayo");
        }

        /// <summary>
        /// Method for holding the bun if desired.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method for holding the lettuce if desired.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            ingredients.Remove("Lettuce");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method for holding the tomato if desired.
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            ingredients.Remove("Tomato");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method for holding the onion if desired.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            ingredients.Remove("Onion");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method for holding the pickle if desired.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            ingredients.Remove("Pickle");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method for holding the ketchup if desired.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            ingredients.Remove("Ketchup");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method for holding the mustard if desired.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            ingredients.Remove("Mustard");
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method for holding the mayo if desired.
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            ingredients.Remove("Mayo");
            NotifyOfPropertyChange("Special");
        }

        public override string ToString()
        {
            return "T-Rex King Burger";
        }

        /// <summary>
        /// Overrides Ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < 3; i++)
                {
                    ingredients.Add("Steakburger Pattie");
                }
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
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
                if (!bun) special.Add("Hold Whole Wheat Bun");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!tomato) special.Add("Hold Tomato");
                if (!onion) special.Add("Hold Onion");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }
    }
}
