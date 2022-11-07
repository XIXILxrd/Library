using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Authors;
using Library.Collection;
using Library.Types_of_genre;

namespace Library
{
    class Book : Literature
    {
        public int PagesAmount { get; }

        public Book(string title, Author author, Genre genre, string publisher, int copiesAmount, int pagesAmount)
            : base(title, author, genre, publisher, copiesAmount)
        {
            PagesAmount = pagesAmount;
        }
    }
}
