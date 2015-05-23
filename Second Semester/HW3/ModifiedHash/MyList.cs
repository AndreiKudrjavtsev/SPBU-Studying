using System;

namespace newHash
{
    public class MyList<T>
    {
        public ListElement head;

        public class ListElement
        {
            /// <summary>
            /// Value of list element
            /// </summary>
            public T value { get; set; }
            /// <summary>
            /// link to the next list element
            /// </summary>
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
        /// Function, deleting element by set value
        /// </summary>
        /// <param name="value"></param>
        public void DeleteByValue(T value)
        {
            if (Equals(head.value, value))
            {
                head = head.next;
                return;
            }
            ListElement tmp = new ListElement();
            tmp = head;
            while (tmp != null)
            {
                if (Equals(tmp.value, value))
                {
                    tmp = tmp.next;
                    return;
                }
                tmp = tmp.next;
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
        /// Function, checking the content of element in list
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsContains(T value)
        {
            ListElement tmp = head;
            while (tmp != null)
            {
                if (Equals(tmp.value, value))
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
    }
}
