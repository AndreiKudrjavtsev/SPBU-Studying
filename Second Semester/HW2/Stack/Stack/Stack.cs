using System;

namespace HW2_Stack
{
    public class Stack<Type>
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

        /// <summary>
        /// Function, adding element in stack
        /// </summary>
        /// <param name="element"></param>
        public void Push(Type value)
        {
            StackElement newElement = new StackElement();
            newElement.next = head;
            newElement.value = value;
            head = newElement;
        }

        /// <summary>
        /// Function, deleting head element in stack
        /// </summary>
        public void Pop()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            head = head.next;
        }

        /// <summary>
        /// Function, checking emptiness of stack
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return head == null;
        }

        /// <summary>
        /// Function, returning head element in stack
        /// </summary>
        /// <returns></returns>
        public Type Peek()
        {
            return head.value;
        }

        /// <summary>
        /// Function, printing stack on console
        /// </summary>
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
