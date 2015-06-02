using System;

namespace StackCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> arrayStack = new ArrayStack<int>(1);
            StackCalculator calculator = new StackCalculator();
            Console.WriteLine(calculator.StackCalc(arrayStack, "10 5 +"));
        }
    }
}
