using System;
using StackCalculator;

namespace StackCalculator
{
    public class ListStack<T> : IStack<T>
    {
        private StackElement head;

        private class StackElement
        {
            /// <summary>
            /// value of stack element 
            /// </summary>
            public T value { get; set; }
            /// <summary>
            /// link to the next stack element
            /// </summary>
            public StackElement next { get; set; }
        }

        public void Push(T value)
        {
            StackElement newElement = new StackElement();
            newElement.next = head;
            newElement.value = value;
            head = newElement;
        }

        public void Pop()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            head = head.next;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public T Peek()
        {
            return head.value;
        }

        public void PrintStack()
        {
            StackElement tmp = head;
            while (tmp.next != null)
            {
                Console.Write("{0} ", tmp.value);
                tmp = tmp.next;
            }
            Console.WriteLine();
        }
    }
}
