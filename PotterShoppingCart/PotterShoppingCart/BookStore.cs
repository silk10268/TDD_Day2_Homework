﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore
{
    public class BookStore
    {
        public Dictionary<int,double> Discount { get; set; }

        public BookStore()
        {
            Discount = new Dictionary<int, double> { };
            Discount[1] = 1.0;
            Discount[2] = 0.95;
            Discount[3] = 0.9;
            Discount[4] = 0.8;
            Discount[5] = 0.75;

        }

        public double CalculatePrice(ShoppingCart shoppingCart)
        {
            int episodeCount = shoppingCart.BookCount.Select((x) => x.Book.Episode).Distinct().Count();
            return shoppingCart.BookCount.Sum((x) => x.Book.Price * x.Count) * Discount[episodeCount];
        }

    }
}
