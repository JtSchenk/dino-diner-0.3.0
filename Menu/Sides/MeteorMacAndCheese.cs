using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// Protected variable size inherited from the Size class.
        /// </summary>
        protected Size size;

        /// <summary>
        /// This method gets and returns the size and then sets the cases for if the size is small, medium, or large
        /// and then sets the prices and calories depending on the size.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
        }

        /// <summary>
        /// This method initiliazes the price, calories, and ingredients for the MeteorMacAndCheese.
        /// </summary>
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;
            Ingredients.Add("Macaroni Noodles");
            Ingredients.Add("Cheese Product");
            Ingredients.Add("Pork Sausage");
        }

        public override string ToString()
        {
            return size + " Meteor Mac and Cheese";
        }

        /// <summary>
        /// Gets Ingredients
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Macaroni Noodles");
                Ingredients.Add("Cheese Product");
                Ingredients.Add("Pork Sausage");
                return Ingredients;
            }
        }
    }
}
