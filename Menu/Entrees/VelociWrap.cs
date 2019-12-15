using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class VelociWrap : Entree
    {
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
        }

        /// <summary>
        /// Method that holds the lettuce if desired.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            ingredients.Remove("Romaine Lettuce");
        }

        /// <summary>
        /// Method that holds the cheese if desired.
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            ingredients.Remove("Parmesan Cheese");
        }

        public override string ToString()
        {
            return "Veloci-Wrap";
        }

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
    }
}
