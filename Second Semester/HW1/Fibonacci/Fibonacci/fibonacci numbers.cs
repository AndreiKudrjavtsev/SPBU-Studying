using System;

namespace HW1
{
    class FibonacciNumbers
    {
        public static int iterFibNums(int number)
        {
            int fibNum1 = 0;
            int fibNum2 = 1;
            int newFib = 0;
            if (number <= 1)
                return number;
            else
            {
                for (int i = 1; i < number; ++i)
                {
                    newFib = fibNum1 + fibNum2;
                    fibNum1 = fibNum2;
                    fibNum2 = newFib;
                }
                return newFib;
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int result = iterFibNums(number);
            Console.WriteLine("Your result: " + result);
        }
    }
}