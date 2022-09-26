using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Authors
{
    internal class Hawking: Author
    {
        public Hawking(string initials, string dateOfBirth)
            : base(initials, dateOfBirth)
        { }

        public override string AboutAuthor()
        {
            return "Hawking was an English theoretical physicist, cosmologist.";
        }
    }
}
