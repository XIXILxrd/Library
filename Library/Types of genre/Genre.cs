using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]

    public abstract class Genre
    {
        public string Description { get; }

        public Genre(string description)
        {
            Description = description;
        }
    }
}
