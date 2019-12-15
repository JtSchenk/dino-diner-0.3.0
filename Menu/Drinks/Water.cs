/* 
 * Water.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink, IMenuItem
    {
        /// <summary>
        /// public variable for lemonforwater. Gets, sets, and initially false.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// public variable for iceforwater. Gets, sets, and intially true.
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// private backing variable size.
        /// </summary>
        private Size size;

        /// <summary>
        /// This checks and sets the size equal to small, medium, or large and gives them
        /// a Price & Calories value.
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                // set the prices for small, medium, and large
                if (size == Size.Small)
                {
                    Price = 0.10;
                    Calories = 0;
                }
                if (size == Size.Medium)
                {
                    Price = 0.10;
                    Calories = 0;
                }
                if (size == Size.Large)
                {
                    Price = 0.10;
                    Calories = 0;
                }
            }
        }

        /// <summary>
        /// Initiliazes the default values.
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            ingredients.Add("Water");
        }

        /// <summary>
        /// Method for adding a lemon
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            if (Lemon)
            {
                ingredients.Add("Lemon");
            }
        }

        /// <summary>
        /// Method for holding the ice.
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }

        /// <summary>
        /// Overrides the ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Water";
        }
    }
}
