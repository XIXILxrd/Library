using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    abstract class Author : IComparable<Author>
    {
        public string Initials { get; }
        public string DateOfBirth { get; }

        public Author(string initials, string dateOfBirth)
        {
            Initials = initials;
            DateOfBirth = dateOfBirth;
        }

        public int CompareTo(Author? other)
        {
            if (other is null)
            {
                throw new ArgumentException("Object is not a Author");
            }

            if (this.Initials.CompareTo(other.Initials) != 0)
            {
                return this.Initials.CompareTo(other.Initials);
            }
            else if (this.DateOfBirth.CompareTo(other.DateOfBirth) != 0)
            {
                return this.DateOfBirth.CompareTo(other.DateOfBirth);
            }
            else
            {
                return 0;
            }
        }
    }
}
