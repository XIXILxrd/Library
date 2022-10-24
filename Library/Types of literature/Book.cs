using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Collection;

namespace Library
{
    class Book : Literature
    {
        public int PagesAmount { get; }

        public Book(string title, LinkList<Author> author, LinkList<Genre> genre, string publisher, int copiesAmount, int pagesAmount)
            : base(title, author, genre, publisher, copiesAmount)
        {
            PagesAmount = pagesAmount;
        }
    }
}
