using System;

namespace HW1
{
    class MatrixSort
    {
        // Anywhere: n - rows amount, m - columns amount. 
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
            fillMatrix(matrix, n, m, rangeMin, rangeMax);
            Console.WriteLine("Source matrix: ");
            printMatrix(matrix, n, m);

            matrixSort(matrix, n, m);
            Console.WriteLine("Sorted by columns matrix: ");
            printMatrix(matrix, n, m);
        }

        // Function, that is filling matrix with random numbers from earlier setted range.
        static void fillMatrix(int[][] matrix, int n, int m, int rangeMin, int rangeMax)
        {
            Random x = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i][j] = x.Next(rangeMin, rangeMax);
        }

        // Function, that is printing matrix on console.
        static void printMatrix(int[][] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("{0}\t", matrix[i][j]);
                Console.WriteLine();
            }
        }

        // Functions, that is swapping 2 columns
        // Indexes i and j - indexes of columns we want to swap.
        static void swapColumns(int[][] matrix, int n, int m, int i, int j)
        {
            for (int k = 0; k < n; k++)
            {
                int tmp;
                tmp = matrix[k][i];
                matrix[k][i] = matrix[k][j];
                matrix[k][j] = tmp;
            }
        }

        // Bubble sort for columns of matrix.
        static void matrixSort(int[][] matrix, int n, int m)
        {
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - 1 - i; j++)
                    if (matrix[0][j] > matrix[0][j + 1])
                        swapColumns(matrix, n, m, j, j + 1);
        }
    }
}