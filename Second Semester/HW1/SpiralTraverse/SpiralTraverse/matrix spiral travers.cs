using System;

namespace HW1
{
    class SpiralTraverse
    {
        // Everywhere: n - dimension of matrix. 
        public static void Main()
        {
            Console.WriteLine("Enter matrix dimension (1 odd number): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the range of values in matrix (2 numbers): ");
            int rangeMin = int.Parse(Console.ReadLine());
            int rangeMax = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
                matrix[i] = new int[n];
            fillMatrix(matrix, n, rangeMin, rangeMax);
            Console.WriteLine("Source matrix: ");
            printMatrix(matrix, n);

            Console.WriteLine("Matrix, traversed by spiral (start point - center): ");
            traverse(matrix, n);
            Console.WriteLine();
        }

        // Function, that is filling matrix with random numbers from earlier setted range.
        static void fillMatrix(int[][] matrix, int n, int rangeMin, int rangeMax)
        {
            Random x = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i][j] = x.Next(rangeMin, rangeMax);
        }

        // Function, that is printing matrix on console.
        static void printMatrix(int[][] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0}\t", matrix[i][j]);
                Console.WriteLine();
            }
        }

        // Function, that is printing elements of  matrix, traversing by spiral.
        static void traverse(int[][] matrix, int n)
        {
            int amountOfVisited = 0;
            int posRow = n / 2;
            int posColumn = n / 2;
            Console.Write(matrix[posRow][posColumn] + " ");
            amountOfVisited++;
            string s = "up";
            int stepsAmount = 1;
            while (amountOfVisited != n * n)
            {
                switch (s)
                {
                    case "up":
                        for (int i = 0; i < stepsAmount; i++)
                        {
                            if (posRow > 0)
                            {
                                posRow--;
                                Console.Write(matrix[posRow][posColumn] + " ");
                                amountOfVisited++;
                            }
                        }
                        s = "right";
                        break;

                    case "right":
                        for (int i = 0; i < stepsAmount; i++)
                        {
                            if (posColumn < n)
                            {
                                posColumn++;
                                Console.Write(matrix[posRow][posColumn] + " ");
                                amountOfVisited++;
                            }
                        }
                        s = "down";
                        stepsAmount++;
                        break;

                    case "down":
                        for (int i = 0; i < stepsAmount; i++)
                        {
                            if (posRow < n)
                            {
                                posRow++;
                                Console.Write(matrix[posRow][posColumn] + " ");
                                amountOfVisited++;
                            }
                        }
                        s = "left";
                        break;

                    case "left":
                        for (int i = 0; i < stepsAmount; i++)
                        {
                            if (posColumn > 0)
                            {
                                posColumn--;
                                Console.Write(matrix[posRow][posColumn] + " ");
                                amountOfVisited++;
                            }
                        }
                        s = "up";
                        stepsAmount++;
                        break;
                }
            }
        }
    }
}