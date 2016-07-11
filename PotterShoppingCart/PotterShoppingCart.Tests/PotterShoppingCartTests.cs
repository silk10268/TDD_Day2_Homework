using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        [TestMethod()]
        public void CalculatePriceTest_Buy_Episode_1_Price_100()
        {
            //arrange
            var shoppingCart = new PotterShoppingCart();
            var target = new Dictionary<Book, int> { { new Book { Name = "Potter", Episode = 1, Price = 100 }, 1 } };

            //act
            var actual = shoppingCart.CalculatePrice(target);
            var expected = 100;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}