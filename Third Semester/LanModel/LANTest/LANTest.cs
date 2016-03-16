using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LanModel;

namespace LanTest
{
    [TestClass]
    public class LANTest
    {
        [TestMethod]
        public void LanTestMethod1()
        {
            bool[,] relationsMatrix = new bool[3, 3];
            relationsMatrix[0, 0] = true;
            relationsMatrix[0, 1] = true;
            relationsMatrix[0, 2] = false;

            relationsMatrix[1, 0] = true;
            relationsMatrix[1, 1] = true;
            relationsMatrix[1, 2] = true;

            relationsMatrix[2, 0] = false;
            relationsMatrix[2, 1] = true;
            relationsMatrix[2, 2] = true;

            Lan.Computer[] computers = new Lan.Computer[3];
            computers[0].Infected = true;
            computers[0].InfectionChance = 1;
            computers[1].Infected = false;
            computers[1].InfectionChance = 1;
            computers[2].Infected = false;
            computers[2].InfectionChance = 1;
            Lan lan = new Lan(relationsMatrix, computers);

            lan.MakeMove();
            lan.MakeMove();
            Assert.IsTrue(lan.AllInfected());
        }

        [TestMethod]
        public void LanTestMethod2()
        {
            bool[,] relationsMatrix = new bool[3, 3];
            relationsMatrix[0, 0] = true;
            relationsMatrix[0, 1] = true;
            relationsMatrix[0, 2] = false;

            relationsMatrix[1, 0] = true;
            relationsMatrix[1, 1] = true;
            relationsMatrix[1, 2] = false;

            relationsMatrix[2, 0] = false;
            relationsMatrix[2, 1] = false;
            relationsMatrix[2, 2] = true;

            Lan.Computer[] computers = new Lan.Computer[3];
            computers[0].Infected = true;
            computers[0].InfectionChance = 0.1;
            computers[1].Infected = false;
            computers[1].InfectionChance = 0.1;
            computers[2].Infected = false;
            computers[2].InfectionChance = 1;
            Lan lan = new Lan(relationsMatrix, computers);

            for (int i = 0; i < 1000; i++)
                lan.MakeMove();

            Assert.IsTrue(computers[0].Infected);
            Assert.IsTrue(computers[1].Infected);
            Assert.IsFalse(computers[2].Infected);
        }
    }
}
