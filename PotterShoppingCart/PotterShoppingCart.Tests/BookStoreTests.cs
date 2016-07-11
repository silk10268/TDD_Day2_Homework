using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}