using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Collection;

namespace Library
{
    internal class Hall : IHall
    {
        private LinkList<Author> author;
        private LinkList<Genre> genre;
        private LinkList<Literature> literatures;

        public Hall(LiteratureFactory factory)
        {
            author = factory.CreateAuthor();
            genre = factory.CreateGenre();
            literatures = factory.CreateLiterature();
        }

        public LinkList<Author> ShowAuthors()
        {
            return author;
        }

        public LinkList<Literature> ShowAvailability()
        {
            return literatures;
        }

        public LinkList<Genre> ShowGenres()
        {
            return genre;
        }
    }
}
