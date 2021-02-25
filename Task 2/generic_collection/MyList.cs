using System.Collections;
using System.Collections.Generic;

namespace generic_collection
{
    public class Element<T>
    {
        public T value;
        public Element<T> next;
    }

    internal class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        public T Current => currentElement.value;

        private Element<T> firstElement;
        private Element<T> currentElement;
        private int counter = 0;
        private int position = -1;

        public int Count()
        {
            return counter;
        }
        public void Add(T item)
        {
            Element<T> bufElement = new Element<T>();
            bufElement.value = item;

            if (firstElement == null)
            {
                firstElement = bufElement;
                currentElement = firstElement;

                counter++;
            }
            else
            {

                currentElement.next = bufElement;
                currentElement = currentElement.next;
                counter++;

            }

        }

        public void Clear()
        {
            if (firstElement != null)
            {
                currentElement = firstElement.next;
                firstElement = null;
                counter--;
            }
            while (currentElement != null)
            {
                firstElement = currentElement.next;
                currentElement = null;
                currentElement = firstElement;
                counter--;
            }
        }

        public bool Contains(T item)
        {
            Element<T> findElement = new Element<T>();
            findElement = firstElement;
            for (int i = 0; i < counter; i++)
            {
                if (findElement.value.Equals(item))
                {
                    return true;
                }
                findElement = findElement.next;
            }
            return false;
        }
        object IEnumerator.Current
        {
            get
            {
                return currentElement.value;
            }
        }


        public MyList(T item)
        {
            firstElement.value = item;
        }

        public MyList()
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (firstElement != null)
            {
                if (position == -1)
                {
                    currentElement = firstElement;
                    position++;
                    return true;
                }
                else if (currentElement.next != null)
                {
                    currentElement = currentElement.next;
                    return true;
                }

            }
            return false;

        }

        public void Reset()
        {

        }

        public void Dispose()
        {
            position = -1;
        }
    }
}