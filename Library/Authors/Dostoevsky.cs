using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Authors
{
    internal class Dostoevsky: Author
    {
        public Dostoevsky(string initials, string dateOfBirth)
            : base(initials, dateOfBirth)
        { }
    }
}
