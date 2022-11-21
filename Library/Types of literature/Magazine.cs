using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Collection;

namespace Library
{
    public class Magazine : Literature
    {
        public string PublicationDate { get; }

        public Magazine(string title, Author author, Genre genre,  string publisher, int copiesAmount, string publicationDate)
            : base(title, author, genre, publisher, copiesAmount)
        {
            PublicationDate = publicationDate;
        }
    }
}
