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

        public string ShowAvailability()
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            foreach(var item in literatures)
            {
                stringBuilder.Append($"{item.Title} - {item.CopiesAmount}\n");
            }

            return stringBuilder.ToString();
        }

        public LinkList<Genre> ShowGenres()
        {
            return genre;
        }
    }
}
