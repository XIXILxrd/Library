using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override string Rent(int amount)
        {
            return CopiesAmount - amount > 0 ? $"{amount} books rented, {CopiesAmount - amount} left." : $"Not enough books.";
        }
    }
}
