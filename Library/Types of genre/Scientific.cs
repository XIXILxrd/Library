using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Types_of_genre
{
    [Serializable]

    public class Scientific : Genre
    {
        public Scientific(string description)
            : base(description)
        { }
    }
}
