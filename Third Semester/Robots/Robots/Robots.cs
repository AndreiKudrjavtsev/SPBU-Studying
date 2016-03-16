using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_namespace
{
    public class Robots
    {
        /// <summary>
        /// Method, that checks if all robots can be destroyed
        /// </summary>
        /// <param name="adjacencyMatrix"></param>
        /// <param name="robotsPositions"></param>
        /// <param name="matrixSize"></param>
        /// <returns></returns>
        public bool AllRobotsCanBeDestroyed(bool[,] adjacencyMatrix, int[] robotsPositions, int matrixSize)
        {
            // Vertexes where robots can be destroyed
            bool[] criticalVertexes = new bool[matrixSize];
            // Array of vertexes for check if vertex was visited
            bool[] arrayOfVertexes = new bool[matrixSize];

            for (int i = 0; i < matrixSize; i++)
                for (int j = 0; j < robotsPositions.Length; j++)
                    for (int k = 0; k < robotsPositions.Length; k++)
                        if (k != j)
                        {
                            if (PathToVertex(adjacencyMatrix, robotsPositions[j], i,matrixSize, arrayOfVertexes) 
                                && PathToVertex(adjacencyMatrix, robotsPositions[k], i, matrixSize, arrayOfVertexes))
                            {
                                criticalVertexes[i] = true;
                                j = robotsPositions.Length;
                                break;
                            }
                        }
            for (int i = 0; i < robotsPositions.Length; i++)
                for (int j = 0; j < matrixSize; j++)
                {
                    if (criticalVertexes[j])
                        if (PathToVertex(adjacencyMatrix, robotsPositions[i], j, matrixSize, arrayOfVertexes))
                            break;
                    if (j == criticalVertexes.Length - 1)
                        return false;
                }

            return true;
        }

        /// <summary>
        /// Method, that returns true if there is a path between 2 vertexes (bypassing one vertex) 
        /// </summary>
        /// <param name="adjacencyMatrix"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="matrixSize"></param>
        /// <param name="arrayOfVertexes"></param>
        /// <returns></returns>
        private bool PathToVertex(bool[,] adjacencyMatrix, int a, int b, int matrixSize, bool[] arrayOfVertexes)
        {            
            arrayOfVertexes[a] = true;

            for (int i = 0; i < matrixSize; i++)
            {
                if (adjacencyMatrix[a, i] && adjacencyMatrix[i, b])
                {
                    Array.Clear(arrayOfVertexes, 0, arrayOfVertexes.Length);
                    return true;
                }
                else if (adjacencyMatrix[a, i])
                {
                    for (int j = 0; j < matrixSize; j++)
                    {
                        if (adjacencyMatrix[i, j] && !arrayOfVertexes[j])
                        {
                            if (PathToVertex(adjacencyMatrix, j, b, matrixSize, arrayOfVertexes))
                            {
                                Array.Clear(arrayOfVertexes, 0, arrayOfVertexes.Length);
                                return true;
                            }
                        }
                    }
                }
            }
            Array.Clear(arrayOfVertexes, 0, arrayOfVertexes.Length);
            return false;
        }
    }
}
