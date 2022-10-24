using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Collection
{
    class Sorting<T> : IComparer<T>
    {
        private LinkList<T> list;
        private Node<T> head;

        public Sorting(LinkList<T> list)
        {
            this.list = list;
            head = list.GetHead(); 
        }

        public int Compare(T? x, T? y)
        {
            throw new NotImplementedException();
        }
    }
}
