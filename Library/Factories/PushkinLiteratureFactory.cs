using Library.Authors;
using Library.Collection;
using Library.Types_of_genre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Halls
{
    internal class PushkinLiteratureFactory : LiteratureFactory
    {
        public override LinkList<Literature> CreateLiterature()
        {
            LinkList<Literature> literatures = new LinkList<Literature>();

            literatures.Add(new Book(title: "Tales",
                                    author: CreateAuthor(),
                                    genre: CreateGenre(),
                                    publisher: "Moscow",
                                    copiesAmount: 110,
                                    pagesAmount: 1500));
            return literatures;
        }

        public override LinkList<Author> CreateAuthor()
        {
            LinkList<Author> authors = new LinkList<Author>();

            authors.Add(new Pushkin("Pushkin A. S", "6.06.1799"));

            return authors;
        }

        public override LinkList<Genre> CreateGenre()
        {
            LinkList<Genre> genres = new LinkList<Genre>();

            genres.Add(new Tale("Short funny story."));

            return genres;
        }
    }
}
