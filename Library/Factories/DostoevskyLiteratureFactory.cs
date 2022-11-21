using Library.Authors;
using Library.Collection;
using Library.Types_of_genre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Factories
{
    [Serializable]

    public class DostoevskyLiteratureFactory : LiteratureFactory
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

        public override Author CreateAuthor()
        {
            return new Dostoevsky("Dostoevsky F. M", "11.10.1821");
        }

        public override Genre CreateGenre()
        {
            return new Novel("Long story.");
        }
    }
}
