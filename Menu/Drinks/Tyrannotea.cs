/*
 * Tyrannotea.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink, IMenuItem
    {
        /// <summary>
        /// public variable that sets sweet to false.
        /// </summary>
        public bool Sweet { get; set; } = false;

        /// <summary>
        /// public variable that sets lemon to false.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// public variable that sets Ice to false.
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// private backing variable Size.
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
                // set the prices for small and large
                if (size == Size.Small)
                {
                    Price = 0.99;
                    Calories = 8;
                    if (Sweet)
                    {
                        Calories = 16;
                    }
                }
                if (size == Size.Medium)
                {
                    Price = 1.49;
                    Calories = 16;

                    if (Sweet)
                    {
                        Calories = 32;
                    }
                }
                if (size == Size.Large)
                {
                    Price = 1.99;
                    Calories = 32;
                    if (Sweet)
                    {
                        Calories = 64;
                    }
                }
            }
        }

        /// <summary>
        /// This method adds a lemon.
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
        /// This method adds Cane Sugar.
        /// </summary>
        public void AddCaneSugar()
        {
            Sweet = true;
            if (Sweet)
            {
                ingredients.Add("Cane Sugar");
            }
        }

        public void HoldIce()
        {
            Ice = false;
        }

        /// <summary>
        /// This method has the default ingredients, Price, and Calories.
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            ingredients.Add("Water");
            ingredients.Add("Tea");
        }

        /// <summary>
        /// Overrides the ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Sweet)
            {
                return size + " Sweet Tyrannotea";
            }
            else
            {
                return size + " Tyrannotea";
            }
        }

        /// <summary>
        /// Overrides Ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Tea");
                if (Lemon)
                {
                    ingredients.Add("Lemon");
                }
                if (Sweet)
                {
                    ingredients.Add("Cane Sugar");
                }
                return ingredients;
            }
        }
    }
}
