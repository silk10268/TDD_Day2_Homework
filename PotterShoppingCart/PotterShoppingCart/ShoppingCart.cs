using System;
using System.Collections.Generic;

namespace BookStore
{
    public class ShoppingCart
    {
        private List<BookCount> _bookCount= new List<BookCount>();

        public List<BookCount> BookCount
        {
            get { return _bookCount; }
        }

        public ShoppingCart()
        {

        }

        public void AddBookCount(BookCount bookCount)
        {
            _bookCount.Add(bookCount);
        }
    }
}