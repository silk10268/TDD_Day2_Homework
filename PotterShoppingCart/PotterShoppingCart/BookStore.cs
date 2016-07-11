using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore
{
    public class BookStore
    {
        public BookStore()
        {

        }

        public int CalculatePrice(ShoppingCart shoppingCart)
        {
            return shoppingCart.BookCount.Sum((x) => x.Book.Price * x.Count);
        }

    }
}
