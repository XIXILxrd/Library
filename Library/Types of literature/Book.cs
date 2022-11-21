namespace Library
{
    public class Book : Literature
    {
        public int PagesAmount { get; }

        public Book(string title, Author author, Genre genre, string publisher, int copiesAmount, int pagesAmount)
            : base(title, author, genre, publisher, copiesAmount)
        {
            PagesAmount = pagesAmount;
        }
    }
}
