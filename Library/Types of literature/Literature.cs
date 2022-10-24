using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Collection;
using Library.Authors;

namespace Library
{
    abstract class Literature : IComparable<Literature>
    {
        public  string Title { get; }
        public LinkList<Author> Author { get; }
        public string Publisher { get; }
        public LinkList<Genre> Genre { get; }
        public int CopiesAmount { get; }

        public Literature(string title, LinkList<Author> author, LinkList<Genre> genre, string publisher, int copiesAmount)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Publisher = publisher;
            CopiesAmount = copiesAmount;
        }

        public override string ToString()
        {
            return Title;
        }

        public int CompareTo(Literature? other)
        {
            if (other is null)
            {
                throw new ArgumentException("Object is not a Literature");
            }

            if (this.Title.CompareTo(other.Title) != 0)
            {
                return this.Title.CompareTo(other.Title);
            }
            else if (this.Publisher.CompareTo(other.Publisher) != 0)
            {
                return this.Publisher.CompareTo(other.Publisher);
            }
            else if (this.Author.CompareTo(other.Author) != 0)
            {
                return this.Author.CompareTo(other.Author);
            }
            else if (this.Genre.CompareTo(other.Genre) != 0)
            {
                return this.Genre.CompareTo(other.Genre);
            }
            else
            {
                return 0;
            }
        }
    }
}
