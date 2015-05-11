using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericClasses
{
    public class GenericList<T> : IEnumerable<T>
    {
        private ListElement head;

        public class ListElement
        {
            public T value { get; set; }
            public ListElement next { get; set; }
        }

        /// <summary>
        /// Function, adding element as head of the list
        /// </summary>
        /// <param name="value"></param>
        public void InsertAsHead(T value)
        {
            ListElement newElement = new ListElement();
            newElement.value = value;
            newElement.next = head;
            head = newElement;
        }

        /// <summary>
        /// Function, adding element in set position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position"></param>
        public void InsertInPosition(T value, ListElement position)
        {
            ListElement newElement = new ListElement();
            newElement.value = value;
            newElement.next = position.next;
            position.next = newElement;
        }

        /// <summary>
        /// Function, deleting element from set position
        /// </summary>
        /// <param name="position"></param>
        public void DeleteInPosition(ListElement position)
        {
            position.next = position.next.next;
        }

        /// <summary>
        /// Function, deleting element by set value
        /// </summary>
        /// <param name="value"></param>
        public void DeleteByValue(T value)
        {
            ListElement tmp = new ListElement();
            tmp = head;
            while (tmp != null)
            {
                if (Equals(tmp.next.value, value))
                    tmp.next = tmp.next.next;
            }
        }

        /// <summary>
        /// Function, checking emptiness of list
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return head == null;
        }

        /// <summary>
        /// Function, checking contents of element in list
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsContains(T value)
        {
            ListElement tmp = head;
            while (tmp != null)
            {
                if (Equals(tmp.next.value, value))
                    return true;
                tmp = tmp.next;
            }
            return false;
        }

        /// <summary>
        /// Function, printing list on console
        /// </summary>
        public void PrintList()
        {
            ListElement tmp = head;
            while (tmp != null)
            {
                Console.Write("{0} ", tmp.value);
                tmp = tmp.next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Function, returning list size
        /// </summary>
        /// <returns></returns>
        public int ListSize()
        {
            ListElement tmp = head;
            int size = 0;
            while (tmp != null)
            {
                size++;
                tmp = tmp.next;
            }
            return size;
        }

        public IEnumerator<T> GetEnumerator()
        {
            ListElement tmp = head;
            while (tmp != null)
            {
                yield return tmp.value;
                tmp = tmp.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
