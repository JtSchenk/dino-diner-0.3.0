﻿using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
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
    }
}
