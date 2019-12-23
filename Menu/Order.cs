/*
 * Order.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for order
    /// </summary>
    public class Order
    {
        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
        }

        //Backing variable
        private ObservableCollection<IOrderItem> items;
        /// <summary>
        /// Items that have been added to the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }

        /// <summary>
        /// Total price of all items in order
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal = 0;
                foreach (IOrderItem item in Items)
                {
                    subtotal += item.Price;
                }
                if (subtotal > 0) { return subtotal; }
                else { return 0; }
            }
        }


        public double SalesTaxRate { get; protected set; } = .1;

        public double SalesTaxCost { get { return SubtotalCost * SalesTaxRate; } }

        public double TotalCost { get { return SubtotalCost + SalesTaxCost; } }

    }
}
