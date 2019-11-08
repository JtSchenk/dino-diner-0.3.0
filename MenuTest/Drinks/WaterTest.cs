/*
 * WaterTest.cs
 * Author: Jacob Schenkelberg
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    /// <summary>
    /// This is a set of test cases for the Water class.
    /// </summary>
    public class WaterTest
    {
        /// <summary>
        /// Checks to see if the default price is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            Water wat = new Water();
            Assert.Equal<double>(0.10, wat.Price);
        }

        /// <summary>
        /// Checks to see if the default calories is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Water wat = new Water();
            Assert.Equal<uint>(0, wat.Calories);
        }

        /// <summary>
        /// Checks to see if the default size is correct (should be small).
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Water wat = new Water();
            Assert.Equal<Size>(Size.Small, wat.Size);
        }

        /// <summary>
        /// Checks to see if the default lemon is set to false.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water wat = new Water();
            Assert.False(wat.Lemon);
        }

        /// <summary>
        /// Checks to see if the price is set to the price of a small drink.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water wat = new Water();
            wat.Size = Size.Large;
            wat.Size = Size.Small;
            Assert.Equal<double>(0.10, wat.Price);
        }

        /// <summary>
        /// Checks to see if the price is set to the price of a medium drink.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            Assert.Equal<double>(0.10, wat.Price);
        }

        /// <summary>
        /// Checks to see if the price is set to the price of a large drink.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water wat = new Water();
            wat.Size = Size.Large;
            Assert.Equal<double>(0.10, wat.Price);
        }

        /// <summary>
        /// Checks to see if the calories are correct after setting the drink to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            wat.Size = Size.Small;
            Assert.Equal<double>(0, wat.Calories);
        }

        /// <summary>
        /// Checks to see if the calories are correct after setting the drink to medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water wat = new Water();
            wat.Size = Size.Medium;
            Assert.Equal<double>(0, wat.Calories);
        }

        /// <summary>
        /// Checks to see if the calories are correct after setting the drink to large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water wat = new Water();
            wat.Size = Size.Large;
            Assert.Equal<double>(0, wat.Calories);
        }

        /// <summary>
        /// Checks to see if the HoldIce method was properly implemented.
        /// Should return an ice boolean of false.
        /// </summary>
        [Fact]
        public void ShouldHoldIce()
        {
            Water wat = new Water();
            wat.HoldIce();
            Assert.False(wat.Ice);
        }

        /// <summary>
        /// Checks to see if the lemon was added. Should be true.
        /// </summary>
        [Fact]
        public void ShouldAddLemon()
        {
            Water wat = new Water();
            wat.AddLemon();
            Assert.True(wat.Lemon);
        }

        /// <summary>
        /// Checks to see if the ingredients are correct without the lemon
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredientsWithoutLemon()
        {
            Water wat = new Water();
            Assert.Contains<string>("Water", wat.Ingredients);
            if (wat.Lemon == true)
            {
                Assert.Contains<string>("Lemon", wat.Ingredients);
            }
        }

        /// <summary>
        /// Checks to see if the ingredients are correct with the lemon
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredientsWithLemon()
        {
            Water wat = new Water();
            Assert.Contains<string>("Water", wat.Ingredients);
            if(wat.Lemon == true)
            {
                Assert.Contains<string>("Lemon", wat.Ingredients);
            }
        }
    }
}
