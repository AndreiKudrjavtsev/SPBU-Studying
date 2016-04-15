using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robots_namespace;

namespace RobotsTest
{
    [TestClass]
    public class RobotsTest
    {
        [TestMethod]
        public void NoRobotsTest()
        {
            int matrixSize = 3;
            bool[,] adjacencyMatrix = new bool[matrixSize, matrixSize];

            adjacencyMatrix[0, 1] = true;
            adjacencyMatrix[0, 2] = true;

            adjacencyMatrix[1, 0] = true;
            adjacencyMatrix[1, 2] = true;

            adjacencyMatrix[2, 1] = true;
            adjacencyMatrix[2, 0] = true;

            int[] robotPos = new int[0];

            Robots rob = new Robots(robotPos, adjacencyMatrix);

            Assert.IsTrue(rob.AllRobotsCanBeDestroyed());
        }

        [TestMethod]
        public void OneRobotTest()
        {
            int matrixSize = 3;
            bool[,] adjacencyMatrix = new bool[matrixSize, matrixSize];

            adjacencyMatrix[0, 1] = true;
            adjacencyMatrix[0, 2] = true;

            adjacencyMatrix[1, 0] = true;
            adjacencyMatrix[1, 2] = true;

            adjacencyMatrix[2, 1] = true;
            adjacencyMatrix[2, 0] = true;

            int[] robotPos = new int[1];
            robotPos[0] = 0;

            Robots rob = new Robots(robotPos, adjacencyMatrix);

            Assert.IsFalse(rob.AllRobotsCanBeDestroyed());
        }

        [TestMethod]
        public void ManyRobotsTest()
        {
            int matrixSize = 6;
            bool[,] adjacencyMatrix = new bool[matrixSize, matrixSize];

            adjacencyMatrix[0, 1] = true;
            adjacencyMatrix[0, 2] = true;

            adjacencyMatrix[1, 0] = true;
            adjacencyMatrix[1, 2] = true;
            adjacencyMatrix[1, 4] = true;

            adjacencyMatrix[2, 0] = true;
            adjacencyMatrix[2, 1] = true;

            adjacencyMatrix[3, 4] = true;

            adjacencyMatrix[4, 1] = true;
            adjacencyMatrix[4, 3] = true;
            adjacencyMatrix[4, 5] = true;

            adjacencyMatrix[5, 4] = true;

            int[] robotPos = new int[4];
            robotPos[0] = 0;
            robotPos[1] = 2;
            robotPos[2] = 3;
            robotPos[3] = 5;

            Robots rob = new Robots(robotPos, adjacencyMatrix);

            Assert.IsTrue(rob.AllRobotsCanBeDestroyed());
        }

        [TestMethod]
        public void RobotsCantBeDestroyedTest()
        {
            bool[,] adjacencyMatrix = new bool[4, 4];

            adjacencyMatrix[0, 1] = true;
            adjacencyMatrix[0, 3] = true;
            adjacencyMatrix[1, 0] = true;
            adjacencyMatrix[1, 2] = true;
            adjacencyMatrix[2, 1] = true;
            adjacencyMatrix[2, 3] = true;
            adjacencyMatrix[3, 0] = true;
            adjacencyMatrix[3, 2] = true;

            int[] robotPos = new int[2];
            robotPos[0] = 0;
            robotPos[1] = 1;

            Robots robots = new Robots(robotPos, adjacencyMatrix);

            Assert.IsFalse(robots.AllRobotsCanBeDestroyed());
        }
    }
}
