using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Collection;

namespace Library
{
    abstract class Literature
    {
        public  string Title { get; }
        public LinkList<Author> Author { get; }
        public string Publisher { get; }
        public LinkList<Genre> Genre { get; }
        public int CopiesAmount { get; }

        public Literature(string title, LinkList<Author> author, LinkList<Genre> genre, string publisher, int copiesAmount)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Publisher = publisher;
            CopiesAmount = copiesAmount;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
