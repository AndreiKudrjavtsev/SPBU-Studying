using System;

namespace HW2_List
{
    public class List<Type>
    {
        private ListElement head;

        private class ListElement
        {
            /// <summary>
            /// Value of list element
            /// </summary>
            public Type value { get; set; }
            /// <summary>
            /// link to the next list element
            /// </summary>
            public ListElement next { get; set; }
        }

        /// <summary>
        /// Function, adding element as head of the list
        /// </summary>
        /// <param name="value"></param>
        public void InsertAsHead(Type value)
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
        public void InsertInPosition(Type value, ListElement position)
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
        public void DeleteByValue(Type value)
        {
            ListElement tmp = new ListElement();
            tmp = head;
            while (tmp.next != null)
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
        /// Function, checking the content of element in list
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsContains(Type value)
        {
            ListElement tmp = head;
            while (tmp.next != null)
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
    }
}
