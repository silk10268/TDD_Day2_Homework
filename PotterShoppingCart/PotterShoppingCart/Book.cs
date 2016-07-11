namespace BookStore
{
    public class Book
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private int _Episode;

        public int Episode
        {
            get { return _Episode; }
            set { _Episode = value; }
        }

        private int _Price;

        public int Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
    }
}