using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    
    public class Brontowurst : Entree, IMenuItem
    {
        
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
            ingredients.Remove("Whole Wheat Bun");
        }

        /// <summary>
        /// Method for removing peppers.
        /// </summary>
        public void HoldPeppers()
        {
            ingredients.Remove("Peppers");
        }

        /// <summary>
        /// Method for removing onions.
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
        }


        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
