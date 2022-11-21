using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Collection;

namespace Library
{
    public interface IHall
    {
        public Author ShowAuthors();

        public LinkList<Literature> ShowAvailability();

        public Genre ShowGenres();
    }
}
