using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_namespace
{
    public class Robots
    {
        public int[] robotsPositions;
        public bool[,] adjacencyMatrix;
        public bool[] used;
        
        public Robots(int[] robots, bool[,] matrix)
        {
            this.robotsPositions = robots;
            this.adjacencyMatrix = matrix;

            used = new bool[adjacencyMatrix.GetLength(0)];
            for (int i = 0; i < used.Length; i++)
                used[i] = false;     
        }

        /// <summary>
        /// Depth first search through one vertex, finding connected components for vertex given as parameter
        /// Returns number of robots in this connected component
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns></returns>
        public int Dfs(int vertex)
        {
            int robotsInComponent = 0;
            used[vertex] = true;
            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
            {
                if (adjacencyMatrix[vertex, i])
                {
                    for (int j = 0; j < adjacencyMatrix.GetLength(0); j++)
                    {
                        if (!used[j] && adjacencyMatrix[i, j])
                            robotsInComponent += Dfs(j);
                    }
                }
            }

            for (int i = 0; i < robotsPositions.Length; i++)
            {
                if (robotsPositions[i] == vertex)
                    robotsInComponent++;
            }

            return robotsInComponent;
        }

        /// <summary>
        /// Checks, if all robots can be destroyed
        /// Returns true if can, false - otherwise
        /// </summary>
        /// <returns></returns>
        public bool AllRobotsCanBeDestroyed()
        {
            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
            {
                if (!used[i] && (Dfs(i) == 1))
                    return false;
            }
            return true;
        }
    }
}
