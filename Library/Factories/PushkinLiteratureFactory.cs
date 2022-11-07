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

            literatures.Add(new Book(title: "3",
                                    author: CreateAuthor(),
                                    genre: CreateGenre(),
                                    publisher: "AMoscow",
                                    copiesAmount: 110,
                                    pagesAmount: 1500));

            literatures.Add(new Book(title: "2",
                                    author: CreateAuthor(),
                                    genre: CreateGenre(),
                                    publisher: "BMoscow",
                                    copiesAmount: 110,
                                    pagesAmount: 1500));

            literatures.Add(new Book(title: "1",
                                   author: CreateAuthor(),
                                   genre: CreateGenre(),
                                   publisher: "BMoscow",
                                   copiesAmount: 110,
                                   pagesAmount: 1500));

            literatures.Add(new Book(title: "4",
                                   author: CreateAuthor(),
                                   genre: CreateGenre(),
                                   publisher: "BMoscow",
                                   copiesAmount: 110,
                                   pagesAmount: 1500));
            return literatures;
        }

        public override Author CreateAuthor()
        {
            return new Pushkin("Pushkin A. S", "6.06.1799");
        }

        public override Genre CreateGenre()
        {
            return new Tale("Short funny story.");
        }
    }
}
