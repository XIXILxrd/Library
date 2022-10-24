﻿using Library.Authors;
using Library.Collection;
using Library.Types_of_genre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Factories
{
    internal class DostoevskyLiteratureFactory : LiteratureFactory
    {
        public override LinkList<Literature> CreateLiterature()
        {
            LinkList<Literature> literatures = new LinkList<Literature>();

            literatures.Add(new Book(title: "Idiot",
                                    author: CreateAuthor(),
                                    genre: CreateGenre(),
                                    publisher: "SPB",
                                    copiesAmount: 130,
                                    pagesAmount: 500));

            literatures.Add(new Book(title: "Crime and Punishment",
                                    author: CreateAuthor(),
                                    genre: CreateGenre(),
                                    publisher: "SPB",
                                    copiesAmount: 110,
                                    pagesAmount: 600));

            literatures.Add(new Book(title: "Demons",
                                    author: CreateAuthor(),
                                    genre: CreateGenre(),
                                    publisher: "SPB",
                                    copiesAmount: 150,
                                    pagesAmount: 300));

            literatures.Add(new Book(title: "The Brothers Karamazov",
                                    author: CreateAuthor(),
                                    genre: CreateGenre(),
                                    publisher: "SPB",
                                    copiesAmount: 140,
                                    pagesAmount: 1200));

            return literatures;
        }

        public override LinkList<Author> CreateAuthor()
        {
            LinkList<Author> authors = new LinkList<Author>();

            authors.Add(new Dostoevsky("Dostoevsky F. M", "11.10.1821"));

            return authors;
        }

        public override LinkList<Genre> CreateGenre()
        {
            LinkList<Genre> genres = new LinkList<Genre>();

            genres.Add(new Novel("Long story."));

            return genres;
        }
    }
}
