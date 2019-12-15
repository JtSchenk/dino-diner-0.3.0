/*
 * IMenuItem.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IMenuItem
    {
        /// <summary>
        /// Get for Calories
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Get for Price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Get for Ingredients
        /// </summary>
        List<string> Ingredients { get; }
    }
}
