using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BookStore.Tests
{
    [TestClass()]
    public class BookStoreTests
    {
        [TestMethod()]
        public void CalculatePriceTest_Buy_Episode_1_Price_100()
        {
            //arrange
            var bookStore = new BookStore();
            var shoppingCart = new ShoppingCart();
            var bookCount = new BookCount(new Book { Name = "Potter", Episode = 1, Price = 100 }, 1);
            shoppingCart.AddBookCount(bookCount);

            //act
            var actual = bookStore.CalculatePrice(shoppingCart);
            var expected = 100;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePriceTest_Buy_Episode_1_2_Price_190()
        {
            //arrange
            var bookStore = new BookStore();
            var shoppingCart = new ShoppingCart();
            var bookCount = new BookCount(new Book { Name = "Potter", Episode = 1, Price = 100 }, 1);
            shoppingCart.AddBookCounts(new List<BookCount>
                {
                new BookCount(new Book { Name = "Potter", Episode = 1, Price = 100 }, 1),
                new BookCount(new Book { Name = "Potter", Episode = 2, Price = 100 }, 1)
                    });

            //act
            var actual = bookStore.CalculatePrice(shoppingCart);
            var expected = 190;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}