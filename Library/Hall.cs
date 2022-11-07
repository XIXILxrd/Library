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
        private Author author;
        private Genre genre;
        private LinkList<Literature> literatures;

        public Hall(LiteratureFactory factory)
        {
            author = factory.CreateAuthor();
            genre = factory.CreateGenre();
            literatures = factory.CreateLiterature();
        }

        public Author ShowAuthors()
        {
            return author;
        }

        public LinkList<Literature> ShowAvailability()
        {
            return literatures;
        }

        public Genre ShowGenres()
        {
            return genre;
        }
    }
}
