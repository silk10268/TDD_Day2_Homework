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

        [TestMethod]
        public void CalculatePriceTest_Buy_Episode_1_2_3_Price_270()
        {
            //arrange
            var bookStore = new BookStore();
            var shoppingCart = new ShoppingCart();
            shoppingCart.AddBookCounts(new List<BookCount>
                {
                new BookCount(new Book { Name = "Potter", Episode = 1, Price = 100 }, 1),
                new BookCount(new Book { Name = "Potter", Episode = 2, Price = 100 }, 1),
                new BookCount(new Book { Name = "Potter", Episode = 3, Price = 100 }, 1)
                    });

            //act
            var actual = bookStore.CalculatePrice(shoppingCart);
            var expected = 270;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePriceTest_Buy_Episode_1_2_3_4_Price_320()
        {
            //arrange
            var bookStore = new BookStore();
            var shoppingCart = new ShoppingCart();
            shoppingCart.AddBookCounts(new List<BookCount>
                {
                new BookCount(new Book { Name = "Potter", Episode = 1, Price = 100 }, 1),
                new BookCount(new Book { Name = "Potter", Episode = 2, Price = 100 }, 1),
                new BookCount(new Book { Name = "Potter", Episode = 3, Price = 100 }, 1),
                new BookCount(new Book { Name = "Potter", Episode = 4, Price = 100 }, 1)
                    });

            //act
            var actual = bookStore.CalculatePrice(shoppingCart);
            var expected = 320;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePriceTest_Buy_Episode_1_2_3_4_5_Price_375()
        {
            //arrange
            var bookStore = new BookStore();
            var shoppingCart = new ShoppingCart();
            shoppingCart.AddBookCounts(new List<BookCount>
                {
                new BookCount(new Book { Name = "Potter", Episode = 1, Price = 100 }, 1),
                new BookCount(new Book { Name = "Potter", Episode = 2, Price = 100 }, 1),
                new BookCount(new Book { Name = "Potter", Episode = 3, Price = 100 }, 1),
                new BookCount(new Book { Name = "Potter", Episode = 4, Price = 100 }, 1),
                new BookCount(new Book { Name = "Potter", Episode = 5, Price = 100 }, 1)
                    });

            //act
            var actual = bookStore.CalculatePrice(shoppingCart);
            var expected = 375;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculatePriceTest_Buy_Episode_1_2_3_3_Price_370()
        {
            //arrange
            var bookStore = new BookStore();
            var shoppingCart = new ShoppingCart();
            shoppingCart.AddBookCounts(new List<BookCount>
                {
                new BookCount(new Book { Name = "Potter", Episode = 1, Price = 100 }, 1),
                new BookCount(new Book { Name = "Potter", Episode = 2, Price = 100 }, 1),
                new BookCount(new Book { Name = "Potter", Episode = 3, Price = 100 }, 2)
                    });

            //act
            var actual = bookStore.CalculatePrice(shoppingCart);
            var expected = 370;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}