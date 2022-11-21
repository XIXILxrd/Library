using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public abstract class Author
    {
        public string Initials { get; }
        public string DateOfBirth { get; }

        public Author(string initials, string dateOfBirth)
        {
            Initials = initials;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return Initials;
        }
    }
}
