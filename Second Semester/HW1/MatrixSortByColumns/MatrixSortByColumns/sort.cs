using System;

namespace HW1
{
    class MatrixSort
    {
        /// <summary>
        /// Anywhere: n - rows amount, m - columns amount. 
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter the dimension of matrix (amount of rows, then columns): ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
                matrix[i] = new int[m];
            
            Console.WriteLine("Enter the range of values in matrix (2 numbers): ");
            int rangeMin = int.Parse(Console.ReadLine());
            int rangeMax = int.Parse(Console.ReadLine());
            FillMatrix(matrix, rangeMin, rangeMax);
            Console.WriteLine("Source matrix: ");
            PrintMatrix(matrix);

            MatrixSorting(matrix);
            Console.WriteLine("Sorted by columns matrix: ");
            PrintMatrix(matrix);
        }

        /// <summary>
        /// Function, that is filling matrix with random numbers from earlier setted range.
        /// </summary>
        static void FillMatrix(int[][] matrix, int rangeMin, int rangeMax)
        {
            Random x = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix[i].GetLength(0); j++)
                    matrix[i][j] = x.Next(rangeMin, rangeMax);
        }

        /// <summary>
        /// Function, that is printing matrix on console.
        /// </summary>
        static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].GetLength(0); j++)
                    Console.Write("{0}\t", matrix[i][j]);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Functions, that is swapping 2 columns
        /// Indexes i and j - indexes of columns we want to swap.
        /// </summary>
        static void SwapColumns(int[][] matrix, int i, int j)
        {
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                int tmp = matrix[k][i];
                matrix[k][i] = matrix[k][j];
                matrix[k][j] = tmp;
            }
        }

        /// <summary>
        /// Bubble sort for columns of matrix.
        /// </summary>
        static void MatrixSorting(int[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                for (int j = 0; j < matrix[i].GetLength(0) - 1 - i; j++)
                    if (matrix[0][j] > matrix[0][j + 1])
                        SwapColumns(matrix, j, j + 1);
        }
    }
}