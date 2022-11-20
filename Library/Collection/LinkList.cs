using System.Collections;

namespace Library.Collection
{
    delegate LinkList<T> SortType<T>(Func<T, T, int> compare);

    class LinkList<T> : ICollection<T>
    {
        private Node<T>? head;
        private Node<T>? tail;
        private int length;

        SortType<T>? type;

        public Node<T>? GetHead()
        {
            return head;
        }

        public LinkList<T> GetLinkList()
        {
            LinkList<T> list = new LinkList<T>();

            Node<T>? current = head;

            while (current != null)
            {
                list.Add(current.value);

                current = current.next;
            }

            return list;
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

        public LinkList<T>? Sort()
        {
            if (head is null)
            {
                throw new NullReferenceException();
            }

            type = DefaultSort;


            return type?.Invoke(CompareByName); 
        }

        private LinkList<T> BubbleSort(Func<T, T, int> compare)
        {
            LinkList<T>? list = GetLinkList();

            Console.WriteLine("\nUsing BubbleSort\n");


            T[] tempArray = new T[list.Count];
            list.CopyTo(tempArray, 0);

            list.Clear();

            T temp;

            for (int i = 0; i < tempArray.Length; i++)
            {
                for (int j = 0; j < tempArray.Length - i - 1; j++)
                {
                    if (compare(tempArray[j], tempArray[j + 1]) > 0)
                    {
                        temp = tempArray[j];
                        tempArray[j] = tempArray[j + 1];
                        tempArray[j + 1] = temp;
                    }
                }
            }

            LinkList<T> newList = new LinkList<T>();

            foreach(var item in tempArray)
            {
                newList.Add(item);
            }

            return newList;
        }

        private LinkList<T> DefaultSort(Func<T, T, int> compare)
        {
            LinkList<T>? list = GetLinkList();

            Console.WriteLine("\nUsing DefaultSort\n");

            T[] tempArray = new T[list.Count];

            list.CopyTo(tempArray, 0);

            list.Clear();

            Array.Sort(tempArray, (x, y) => compare(x, y));

            LinkList<T> newList = new LinkList<T>();

            foreach (var item in tempArray)
            {
                newList.Add(item);
            }

            return newList;
        }

        private int CompareByName(T a, T b)
        {
            if (a is Literature && b is Literature)
            {
                return ((a as Literature).Title.CompareTo((b as Literature).Title));
            }
            else if (a is Author && b is Author)
            {
                return ((a as Author).Initials.CompareTo((b as Author).Initials));
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private int CompareLitByPublisher(T a, T b)
        {
            if (!(a is Literature) || !(b is Literature))
            {
                throw new ArgumentException();
            }

            return ((a as Literature).Publisher).CompareTo((b as Literature).Publisher);
        }

        private int CompareLitByAmount(T a, T b)
        {
            if (!(a is Literature) || !(b is Literature))
            {
                throw new ArgumentException();
            }

            return ((a as Literature).CopiesAmount).CompareTo((b as Literature).CopiesAmount);
        }
    }
}