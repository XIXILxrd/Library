using Library.Logger;
using System.Collections;

namespace Library.Collection
{
    delegate LinkList<T> SortType<T>(Func<T, T, int> compare);

    [Serializable]
    public class LinkList<T> : ICollection<T>
    {
        Logging<T> log = new Logging<T>();
        
        
        private Node<T>? head;
        private Node<T>? tail;
        private int length;

        SortType<T>? type;

        public Node<T>? GetHead() => head;

        public LinkList<T> GetLinkList()
        {
            log.LogInformation("GetLinkList() was started...");

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

        public Node<T>? this[int index]
        {
            get
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Node<T>? current = head;

                for (int i = 0; i < index; i++)
                {
                    if (current.next == null)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    current = current.next;
                }

                return current;
            }
        }

        public int Count => length;

        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (head is null)
            {
                log.LogInformation($"{value.ToString} was added as head.");

                head = newNode;

                tail = head;

                length++;

                return;
            }

            log.LogInformation($"{value.ToString} was added as head.");

            tail.next = newNode;
            tail = newNode;

            length++;
        }

        public void Add(Object value)
        {
            if (!(value is T))
            {
                throw new ArgumentException();
            }

            Node<T> newNode = new Node<T>((T)value);

            if (head is null)
            {
                log.LogInformation($"{value.ToString} was added as head.");

                head = newNode;

                tail = head;

                length++;

                return;
            }

            log.LogInformation($"{value.ToString} was added.");

            tail.next = newNode;
            tail = newNode;

            length++;
        }

        private bool RemoveHead()
        {
            if (head is null)
            {
                log.LogError("Head is null");

                return false;
            }

            Node<T>? temp = head;

            head = head.next;

            temp = null;

            length--;

            log.LogInformation("Head was removed.");

            return true;
        }

        private bool RemoveTail()
        {
            if (tail is null)
            {
                log.LogError("Tail is null");

                return false;
            }

            Node<T>? previous = head;

            Node<T>? temp = head?.next;

            while (temp.next != null)
            {
                previous = previous.next;
                temp = temp.next;
            }

            previous.next = null;

            tail = previous;

            length--;

            log.LogInformation("Tail was removed.");

            return true;
        }

        private bool RemoveSpecify(T item)
        {
            if (head is null)
            {
                log.LogError("Head is null");

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

            log.LogInformation($"{item.ToString} was removed");

            return isRemoved;
        }

        public bool Remove(T value)
        {
            if (head.value.Equals(value))
            {
                log.LogInformation("Head was removed");

                return RemoveHead();
            }
            else if (tail.value.Equals(value))
            {
                log.LogInformation("Tail was removed");

                return RemoveTail();
            }
            else
            {
                log.LogInformation($"{value.ToString} was removed");

                return RemoveSpecify(value);
            }
        }

        public bool Contains(T item)
        {
            log.LogInformation($"Cotains({item.ToString}) was started");

            bool found = false;

            Node<T>? currentNode = head;

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
                log.LogError("Head is null");

                return;
            }

            while (head != null)
            {
                RemoveHead();
            }

            log.LogInformation("List was cleared.");
        }

        public void Display()
        {
            log.LogInformation("Display() was started.");

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
                log.LogError("Head is null.");

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

            log.LogInformation("List was copied.");
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
                log.LogError("Head is null.");

                throw new NullReferenceException();
            }

            type = DefaultSort;

            log.LogInformation("Sort() was started.");

            return type?.Invoke(CompareByName); 
        }

        private LinkList<T> BubbleSort(Func<T, T, int> compare)
        {
            log.LogInformation("Sort() was started using BubbleSort().");

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
            log.LogInformation("Sort() was started using DefaultSort().");

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
            log.LogInformation($"CompareByName({a}, {b}) was started.");

            if (a is Literature && b is Literature)
            {
                log.LogInformation($"Literatures was compared by name.");

                return ((a as Literature).Title.CompareTo((b as Literature).Title));
            }
            else if (a is Author && b is Author)
            {
                log.LogInformation($"Authors was compared by name.");

                return ((a as Author).Initials.CompareTo((b as Author).Initials));
            }
            else
            {
                log.LogWarning("ArgumentException.");

                throw new ArgumentException();
            }
        }

        private static int CompareLitByPublisher(T a, T b)
        {
            if (!(a is Literature) || !(b is Literature))
            {
                throw new ArgumentException();
            }

            return ((a as Literature).Publisher).CompareTo((b as Literature).Publisher);
        }

        private static int CompareLitByAmount(T a, T b)
        {
            if (!(a is Literature) || !(b is Literature))
            {
                throw new ArgumentException();
            }

            return ((a as Literature).CopiesAmount).CompareTo((b as Literature).CopiesAmount);
        }
    }
}