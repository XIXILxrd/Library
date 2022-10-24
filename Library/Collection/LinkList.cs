using System.Collections;
using Library.Collection;


namespace Library.Collection
{
    class LinkList<T> : ICollection<T>
    {
        private Node<T>? head;
        private Node<T>? tail;
        private int length;

        public Node<T>? GetHead()
        {
            return head;
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public int Count => length;

        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (head is null)
            {
                head = newNode;

                tail = head;

                length++;

                return;
            }

            tail.next = newNode;
            tail = newNode;

            length++;
        }

        private bool RemoveHead()
        {
            if (head is null)
            {
                return false;
            }

            Node<T> temp = head;

            head = head.next;

            temp = null;

            length--;

            return true;
        }

        private bool RemoveTail()
        {
            if (tail is null)
            {
                return false;
            }

            Node<T> previous = head;

            Node<T> temp = head.next;

            while (temp.next != null)
            {
                previous = previous.next;
                temp = temp.next;
            }

            previous.next = null;

            tail = previous;

            length--;

            return true;
        }

        private bool RemoveSpecify(T item)
        {
            if (head is null)
            {
                return false;
            }

            bool isRemoved = false;

            Node<T> previous = head;

            while (previous != null && !isRemoved)
            {
                if (previous.next.value.Equals(item))
                {
                    isRemoved = true;
                    break;
                }

                previous = previous.next;
            }

            Node<T> del = previous.next;
            Node<T> temp = del.next;

            previous.next = temp;

            length--;

            return isRemoved;
        }

        public bool Remove(T value)
        {
            if (head.value.Equals(value))
            {
                return RemoveHead();
            }
            else if (tail.value.Equals(value))
            {
                return RemoveTail();
            }
            else
            {
                return RemoveSpecify(value);
            }
        }

        public bool Contains(T item)
        {
            bool found = false;

            Node<T> currentNode = head;

            while (currentNode != null && !found)
            {
                if (currentNode.value.Equals(item))
                {
                    found = true;
                }

                currentNode = currentNode.next;
            }

            return found;
        }

        public void Clear()
        {
            if (head is null)
            {
                return;
            }

            while (head != null)
            {
                RemoveHead();
            }
        }

        public void Display()
        {
            Node<T> currentNode = head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.value);

                currentNode = currentNode.next;
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (head is null)
            {
                return;
            }

            Node<T> current = head;

            int i = arrayIndex;

            while (current != null && i <= length)
            {
                array[i] = current.value;

                i++;

                current = current.next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ListEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ListEnumerator<T>(this);
        }
    }
}