using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{

    /// <summary>
    /// This public abstract method is a base for a bunch of sub classes.
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Creates a new list of ingredients
        /// </summary>
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets and returns the ingredients into the list of ingredients.
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        public virtual string[] Special { get; }

        /// <summary>
        /// jyes
        /// </summary>
        public virtual string Description { get; }

    }
}
