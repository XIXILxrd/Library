using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Types_of_genre
{
    [Serializable]

    public class Tale : Genre
    {
        public Tale(string description)
            : base(description)
        { }
    }
}
