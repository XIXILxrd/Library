﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Collection
{
    [Serializable]

    public class Node<T>
    {
        public Node<T>? next;
        public T value;

        public Node(T value)
        {
            this.value = value;
            next = null;
        }
    }
}
