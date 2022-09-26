﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Authors
{
    internal class Orwell: Author
    {
        public Orwell(string initials, string dateOfBirth)
            :base(initials, dateOfBirth)
        { }
        public override string AboutAuthor()
        {
            return "Orwell was an English novelist, essayist, journalist, and critic.";
        }
    }
}