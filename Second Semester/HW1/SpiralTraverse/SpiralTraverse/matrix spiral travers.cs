using System;

namespace HW1
{
    class SpiralTraverse
    {
        /// <summary>
        /// Everywhere: n - dimension of matrix. 
        /// </summary>
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
            fillMatrix(matrix, rangeMin, rangeMax);
            Console.WriteLine("Source matrix: ");
            printMatrix(matrix);

            Console.WriteLine("Matrix, traversed by spiral (start point - center): ");
            traverse(matrix);
            Console.WriteLine();
        }

        /// <summary>
        /// Function, that is filling matrix with random numbers from earlier setted range.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="rangeMin"></param>
        /// <param name="rangeMax"></param>
        static void fillMatrix(int[][] matrix,int rangeMin, int rangeMax)
        {
            Random x = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix[i].GetLength(0); j++)
                    matrix[i][j] = x.Next(rangeMin, rangeMax);
        }

        /// <summary>
        /// Function, that is printing matrix on console.
        /// </summary>
        /// <param name="matrix"></param>
        static void printMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].GetLength(0); j++)
                    Console.Write("{0}\t", matrix[i][j]);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Function, that is printing elements of  matrix, traversing by spiral.
        /// </summary>
        /// <param name="matrix"></param>
        static void traverse(int[][] matrix)
        {
            int amountOfVisited = 0;
            int posRow = matrix.GetLength(0) / 2;
            int posColumn = matrix.GetLength(0) / 2;
            Console.Write(matrix[posRow][posColumn] + " ");
            amountOfVisited++;
            int direction = 0;
            int stepsAmount = 1;
            while (amountOfVisited != matrix.GetLength(0) * matrix.GetLength(0))
            {
                switch (direction)
                {
                    case 0:
                        for (int i = 0; i < stepsAmount; i++)
                        {
                            if (posRow > 0)
                            {
                                posRow--;
                                Console.Write(matrix[posRow][posColumn] + " ");
                                amountOfVisited++;
                            }
                        }
                        direction = 1;
                        break;

                    case 1:
                        for (int i = 0; i < stepsAmount; i++)
                        {
                            if (posColumn < matrix.GetLength(0))
                            {
                                posColumn++;
                                Console.Write(matrix[posRow][posColumn] + " ");
                                amountOfVisited++;
                            }
                        }
                        direction = 2;
                        stepsAmount++;
                        break;

                    case 2:
                        for (int i = 0; i < stepsAmount; i++)
                        {
                            if (posRow < matrix.GetLength(0))
                            {
                                posRow++;
                                Console.Write(matrix[posRow][posColumn] + " ");
                                amountOfVisited++;
                            }
                        }
                        direction = 3;
                        break;

                    case 3:
                        for (int i = 0; i < stepsAmount; i++)
                        {
                            if (posColumn > 0)
                            {
                                posColumn--;
                                Console.Write(matrix[posRow][posColumn] + " ");
                                amountOfVisited++;
                            }
                        }
                        direction = 0;
                        stepsAmount++;
                        break;
                }
            }
        }
    }
}