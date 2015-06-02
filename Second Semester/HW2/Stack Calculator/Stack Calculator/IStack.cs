using System;

namespace StackCalculator
{
    public interface IStack<T>
    {
        /// <summary>
        /// Function, adding element in stack
        /// </summary>
        /// <param name="value"> </param>
        void Push(T value);

        /// <summary>
        /// Function, deleting element from stack
        /// </summary>
        void Pop();

        /// <summary>
        /// Function, checking emptiness of stack
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        /// <summary>
        /// Function, returning head element in stack
        /// </summary>
        /// <returns></returns>
        T Peek();

        /// <summary>
        /// Function, printing stack on console
        /// </summary>
        void PrintStack();
    }
}
