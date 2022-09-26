using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public abstract string Rent(int amount);
    }
}
