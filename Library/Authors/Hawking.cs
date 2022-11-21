using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Authors
{
    [Serializable]

    public class Hawking: Author
    {
        public Hawking(string initials, string dateOfBirth)
            : base(initials, dateOfBirth)
        { }
    }
}
