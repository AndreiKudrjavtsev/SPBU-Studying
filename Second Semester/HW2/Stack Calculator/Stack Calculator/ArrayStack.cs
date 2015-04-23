using System;
using HW2_StackCalculator;

namespace HW2_ArrayStack
{
    class ArrayStack<Type> : IStack<Type>
    {
        private int lastElementIndex;
        private Type[] stack;

        public ArrayStack(int size)
        {
            lastElementIndex = 0;
            stack = new Type[size];
        }

        public void Push(Type value)
        {
            if (lastElementIndex == 0)
                Array.Resize(ref stack, stack.Length * 2);
            stack[lastElementIndex] = value;
            lastElementIndex++;
        }

        public void Pop()
        {
            if (lastElementIndex == 0)
                throw new InvalidOperationException("Stack is empty!");
            lastElementIndex--;
        }

        public bool IsEmpty()
        {
            return lastElementIndex == 0;
        }

        public Type Peek()
        {
            if (lastElementIndex == 0)
                throw new InvalidOperationException("Stack is empty!");
            return stack[lastElementIndex];
        }

        public void PrintStack()
        {
            for (int i = lastElementIndex; i >= 0; i--)
                Console.Write("{0} ", stack[i]);
            Console.WriteLine();
        }
    }
}
