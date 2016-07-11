namespace BookStore
{
    public class BookCount
    {
        private Book _Book;

        public Book Book
        {
            get { return _Book; }
        }

        private int _Count;

        public int Count
        {
            get { return _Count; }
        }

        public BookCount(Book book, int count)
        {
            this._Book = book;
            this._Count = count;
        }
    }
}