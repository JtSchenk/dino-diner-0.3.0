/*
 * JurrasicJava.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class JurrasicJava : Drink, IMenuItem, INotifyPropertyChanged
    {
        public override event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// public variable RoomForCream set to false.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// public variable Decaf set to false.
        /// </summary>
        public bool Decaf
        {
            get { return Decaf; }
            set
            {
                NotifyOfPropertyChange("Description");
                Decaf = value;
            }
        }

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
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Description");
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
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Method for adding ice.
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Overrides the ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return $"{Size} Decaf Jurassic Java";
            }
            else
            {
                return $"{Size} Jurassic Java";
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
                if (RoomForCream) ingredients.Add("Room For Cream");
                ingredients.Add("Coffee");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets Description
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets Special modifications
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (RoomForCream) special.Add("Leave Room For Cream");
                if (Ice) special.Add("Add Ice");
                return special.ToArray();
            }
        }
    }
}