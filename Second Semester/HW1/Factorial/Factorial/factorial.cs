using System;

namespace HW1
{
    class Factorial
    {
        public static int factorial(int number)
        {
            if (number < 0)
                return 0;
            if (number == 0 || number == 1)
                return 1;
            else
            {
                int result = 1;
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
                return result;
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int result = factorial(number);
            Console.WriteLine("Your result: " + result);
        }
    }
}