/*
 * JurrasicJava.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// public variable ICE set to false.
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// public variable RoomForCream set to false.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// public variable Decaf set to false.
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Private backing variable size.
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
                    Price = 0.59;
                    Calories = 2;
                }
                if (size == Size.Medium)
                {
                    Price = 0.99;
                    Calories = 4;
                }
                if (size == Size.Large)
                {
                    Price = 1.49;
                    Calories = 8;
                }
            }
        }

        /// <summary>
        /// Creates a default ingredients, price, and calories
        /// </summary>
        public JurrasicJava()
        {
            Price = 0.59;
            Calories = 2;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }

        /// <summary>
        /// Method for leaving room for cream.
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            ingredients.Add("Room For Cream");
        }

        /// <summary>
        /// Method for adding ice.
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }
    }
}
