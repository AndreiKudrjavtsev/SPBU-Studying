using System;

namespace HW1
{
    class BubbleSort
    {
        public static void BubbleSort(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length - 1; ++i)
            {
                for (int j = 0; j < length - 1 - i; ++j)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter the length of array: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the range of values (2 numbers): ");
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            Random x = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = x.Next(min, max);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            BubbleSort(array);
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
}