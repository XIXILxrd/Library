using System.Collections;

namespace Library.Collection
{
    internal class ListEnumerator<T> : IEnumerator<T>
    {
        private LinkList<T> collection;
        private Node<T> currentNode;

        public ListEnumerator(LinkList<T> list)
        {
            this.collection = list;
            currentNode = collection.GetHead();
        }

        public Node<T> Current
        {
            get { return currentNode; }
        }

        object IEnumerator.Current => Current.value;

        T IEnumerator<T>.Current => Current.value;

        public bool MoveNext()
        {
            currentNode = currentNode.next;

            if (currentNode != null)
            {
                return true;
            }
            
            return false;
        }

        public void Reset()
        {
            currentNode = null;
        }

        void IDisposable.Dispose() { }
    }
}
