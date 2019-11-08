/*
 * Drink.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Base class that other classes inherit from.
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// protected variable that creates a new list of ingredients
        /// </summary>
        protected List<string> ingredients = new List<string>();

        /// <summary>
        /// Gets and sets the Price for other classes
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories for other classes
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets and returns the ingredients for other classes
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

    }
}
