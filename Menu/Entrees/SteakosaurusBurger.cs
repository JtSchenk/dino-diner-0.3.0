using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger : Entree
    {
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
            ingredients.Remove("Whole Wheat Bun");
        }

        /// <summary>
        /// This method holds the pickle if desired.
        /// </summary>
        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
        }
         
        /// <summary>
        /// This method holds the ketchup if desired.
        /// </summary>
        public void HoldKetchup()
        {
            ingredients.Remove("Ketchup");
        }

        /// <summary>
        /// This method holds the mustard if desired.
        /// </summary>
        public void HoldMustard()
        {
            ingredients.Remove("Mustard");
        }

    }
}
