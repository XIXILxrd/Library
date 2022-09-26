using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Magazine : Literature
    {
        public string PublicationDate { get; }

        public Magazine(string title, Author author, Genre genre,  string publisher, int copiesAmount, string publicationDate)
            : base(title, author, genre, publisher, copiesAmount)
        {
            PublicationDate = publicationDate;
        }

        public override string Rent(int amount)
        {
            return CopiesAmount - amount > 0 ? $"{amount} magazines rented, {CopiesAmount - amount} left." : $"Not enough magazines.";
        }
    }
}
