using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Collection;

namespace Library
{
    internal interface IHall
    {
        public LinkList<Author> ShowAuthors();

        public LinkList<Literature> ShowAvailability();

        public LinkList<Genre> ShowGenres();
    }
}
