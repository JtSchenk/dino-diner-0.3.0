/*
 * Order.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {

        /// <summary>
        /// Items that have been added to the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }

        /// <summary>
        /// Event handler for property changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
                if (subtotal > 0)
                    return subtotal;
                else
                    return 0;
            }
        }

        /// <summary>
        /// The sales tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; } = .1;

        /// <summary>
        /// The additional costs associated with sales tax
        /// </summary>
        public double SalesTaxCost { get { return SubtotalCost * SalesTaxRate; } }

        /// <summary>
        /// The total cost of the order including the price of the items and sales tax
        /// </summary>
        public double TotalCost { get { return SubtotalCost + SalesTaxCost; } }

        /// <summary>
        /// Creates new order instance
        /// </summary>
        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            Items.CollectionChanged += OnCollectionChanged;
        }


        /// <summary>
        /// Method for Adding an item
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            Items.Add(item);
        }

        /// <summary>
        /// Property Changed for Costs and Items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

    }
}
