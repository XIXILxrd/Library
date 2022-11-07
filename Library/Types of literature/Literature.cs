using Library.Collection;

namespace Library
{
    abstract class Literature
    {
        public  string Title { get; }
        public Author Author { get; }
        public string Publisher { get; }
        public Genre Genre { get; }
        public int CopiesAmount { get; }

        public Literature(string title, Author author, Genre genre, string publisher, int copiesAmount)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Publisher = publisher;
            CopiesAmount = copiesAmount;
        }

        public override string ToString()
        {
            return "\"" + Title + "\", " + Author + ", \"" + Publisher + "\", number of copies: " + CopiesAmount;
        }
    }
}
