using System;

namespace HW2
{
    public class Stack<Type>
    {
        private StackElement head;
        private int length;

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

        

    }
}
