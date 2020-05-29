/*
 * IOrderItem.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Property to get Price.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Property to get Description.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Property to get "special" orders.
        /// </summary>
        string[] Special { get; }
    }
}
