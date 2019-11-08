/*
 * TyrannoteaTest.cs
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
    public class TyrannoteaTest
    {
        /// <summary>
        /// Checks to see if default price is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// Checks to see if default calories is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Checks to see if default size is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        /// <summary>
        /// Checks to see if default ice is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        /// <summary>
        /// Checks to see if default lemon is false.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }

        /// <summary>
        /// Checks to see if default sweet is false.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }

        /// <summary>
        /// Checks to see if price is correct after setting small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// Checks to see if price is correct after setting medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        /// <summary>
        /// Checks to see if price is correct after setting large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        /// <summary>
        /// Checks to see if calories is correct after setting small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Checks to see if calories is correct after setting medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// Checks to see if calories is correct after setting large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        /// <summary>
        /// Checks to see if the ice value is false after invoking HoldIce().
        /// </summary>
        [Fact]
        public void ShouldHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        /// <summary>
        /// Checks to see if the lemon was added correctly.
        /// </summary>
        [Fact]
        public void ShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        /// <summary>
        /// Checks to see if the sweet value was set to true.
        /// </summary>
        [Fact]
        public void ShouldSetSweetPropertyToTrue()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddCaneSugar();
            Assert.True(tea.Sweet);
        }

        /// <summary>
        /// Checks if calories are correct after adding sweet (small).
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterAddingSweetSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddCaneSugar();
            tea.Size = Size.Large;
            tea.Size = Size.Small;
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// Checks if calories are correct after adding sweet (medium).
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterAddingSweetMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddCaneSugar();
            tea.Size = Size.Large;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterAddingSweetLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddCaneSugar();
            tea.Size = Size.Medium;
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
        }

        /// <summary>
        /// Checks to see if the calories after setting sweet to true are correct (small).
        /// </summary>
        [Fact]
        public void ShouldResultInCorrectCaloriesAfterSettingSweetFromTrueToFalseSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddCaneSugar();
            tea.Sweet = false;
            tea.Size = Size.Large;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Checks to see if the calories after setting sweet to true are correct (medium).
        /// </summary>
        [Fact]
        public void ShouldResultInCorrectCaloriesAfterSettingSweetFromTrueToFalseMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddCaneSugar();
            tea.Sweet = false;
            tea.Size = Size.Small;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// Checks to see if the calories after setting sweet to true are correct (large).
        /// </summary>
        [Fact]
        public void ShouldResultInCorrectCaloriesAfterSettingSweetFromTrueToFalseLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddCaneSugar();
            tea.Sweet = false;
            tea.Size = Size.Medium;
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        /// <summary>
        /// Checks to see if the ingredients are correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
        }

        /// <summary>
        /// Checks to see if ingredients are correct after lemon is added.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredientsAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Lemon", tea.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectIngredientsAddSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddCaneSugar();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
        }
    }
}
