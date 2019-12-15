using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree
    {
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
            ingredients.Remove("Peanut Butter");
        }

        /// <summary>
        /// Method that removes the Jelly if desired.
        /// </summary>
        public void HoldJelly()
        {
            ingredients.Remove("Jelly");
        }

        /// <summary>
        /// Overrides the ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

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
    }
}
