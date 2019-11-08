/*
 * JurrasicJavaTest.cs
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
    public class JurrasicJavaTest
    {
        /// <summary>
        /// Checks to see if the Default Price is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
           JurrasicJava java = new JurrasicJava();
           Assert.Equal<double>(0.59, java.Price);
        }

        /// <summary>
        /// Checks to see if the default calories is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        /// <summary>
        /// Checks to see if the default ice is set to false.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.Ice);
        }

        /// <summary>
        /// Checks to see if the default size is correct. Should be default small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        /// <summary>
        /// Checks to see if the Price is correct after setting small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            java.Size = Size.Small;
            Assert.Equal<double>(0.59, java.Price);
        }

        /// <summary>
        /// Checks to see if the price is correct after setting medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(0.99, java.Price);
        }

        /// <summary>
        /// Checks to see if the price is correct after setting large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }

        /// <summary>
        /// Checks to see if the calories is correct after setting small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }


        /// <summary>
        /// Checks to see if the calories is correct after setting medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }


        /// <summary>
        /// Checks to see if the calories is correct after setting large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        /// <summary>
        /// Checks to see if Ice is true.
        /// </summary>
        [Fact]
        public void ShouldAddIce()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        /// <summary>
        /// Checks to see if the LeaveRoomForCream method is correct.
        /// </summary>
        [Fact]
        public void ShouldLeaveSpaceForCream()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        /// <summary>
        /// Checks to see if the ingredients are correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectIngredientsWhenAddRoomForCream()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveRoomForCream();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Contains<string>("Room For Cream", java.Ingredients);
        }
    }
}
