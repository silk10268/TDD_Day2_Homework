using System.Collections.Generic;
using System.Linq;

namespace BookStore
{
    public class BookStore
    {
        private Dictionary<int, double> Discount { get; set; }

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
            double price = 0;
            int episodeCount = shoppingCart.BookCount.Select(x => x.Book.Episode).Distinct().Count();
            int maxCount = shoppingCart.BookCount.Select(x => x.Count).Max();
            for (int i = 1; i <= maxCount; i++)
            {
                double discount = Discount[shoppingCart.BookCount.Where(x => x.Count >= i).Count()];
                price += shoppingCart.BookCount.Where(x => x.Count >= i).Sum(x => x.Book.Price) * discount;
            }
            return price;
        }
    }
}