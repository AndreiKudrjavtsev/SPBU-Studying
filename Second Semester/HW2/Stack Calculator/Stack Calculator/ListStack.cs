using System;
using HW2_StackCalculator;

namespace HW2_ListStack
{
    public class ListStack<Type> : IStack<Type>
    {
        private StackElement head;

        private class StackElement
        {
            /// <summary>
            /// value of stack element 
            /// </summary>
            public Type value { get; set; }
            /// <summary>
            /// link to the next stack element
            /// </summary>
            public StackElement next { get; set; }
        }

        public void Push(Type value)
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

        public Type Peek()
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
