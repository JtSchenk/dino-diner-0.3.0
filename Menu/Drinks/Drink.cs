/*
 * Drink.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Base class that other classes inherit from.
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// protected variable that creates a new list of ingredients
        /// </summary>
        protected List<string> ingredients = new List<string>();

        /// <summary>
        /// Gets and sets Ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets and sets the Price for other classes
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories for other classes
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets and returns the ingredients for other classes
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Provides Description modifications.
        /// </summary>
        public virtual string Description { get; }

        /// <summary>
        /// Special modifications
        /// </summary>
        public virtual string[] Special { get; }

        /// <summary>
        /// PropertyChanged for Special, Price, Description
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// PropertyChanged for Special, Price, Description
        /// </summary>
        private void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void HoldIce()
        {
            NotifyOfPropertyChanged("Special");
            Ice = false;
        }

    }
}
