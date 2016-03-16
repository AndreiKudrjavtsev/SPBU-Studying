using System;

namespace LanModel
{
    /// <summary>
    /// Lan model
    /// </summary>
    public class Lan
    {
        private bool[,] adjacencyMatrix;
        private Computer[] computers;
        private bool[] infected;
        private Random chance;

        public struct Computer
        {
            public Computer(bool infected, double infectionChance)
            {
                Infected = infected;
                InfectionChance = infectionChance;
            }

            public bool Infected { get; set; }
            public double InfectionChance { get; set; }
        }

        public Lan(bool[,] adjacencyMatrix, Computer[] computers)
        {
            this.adjacencyMatrix = adjacencyMatrix;
            this.computers = computers;
            chance = new Random();
            infected = new bool[computers.Length];
            for (int i = 0; i < computers.Length; i++)
            {
                infected[i] = computers[i].Infected;
            }
        }

        /// <summary>
        /// Method for making one step in LAN Model
        /// </summary>
        public void MakeMove()
        {
            for (int i = 0; i < computers.Length; i++)
            {
                if (computers[i].Infected)
                {
                    for (int j = 0; j < computers.Length; j++)
                    {
                        if (adjacencyMatrix[i, j] && chance.NextDouble() < computers[j].InfectionChance &&
                            computers[j].InfectionChance != 0)
                            infected[j] = true;
                    }
                }
            }
            for (int i = 0; i < computers.Length; i++)
                computers[i].Infected = infected[i];
        }
               
        /// <summary>
        /// Method for printing numbers of all infected PCs in our lan.
        /// </summary>
        public void PrintInfected()
        {
            Console.Write("Infected PC numbers: ");
            for (int i = 0; i < computers.Length; i++)
            {
                if (computers[i].Infected)
                    Console.Write("{0} ", i);
            }
        }

        /// <summary>
        /// Method, that checks if all computers are infected
        /// </summary>
        /// <returns> Returns true, if all computers in LAN are infected </returns>
        public bool AllInfected()
        {
            for (int i = 0; i < computers.Length; i++)
            {
                if (!computers[i].Infected)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Method for running LAN Model
        /// Expected connected graph, so stable state for lan is when all computers are infected
        /// </summary>
        public void RunLanModel()
        {
            while (true)
            {
                MakeMove();
                PrintInfected();
                Console.WriteLine();
                if (AllInfected())
                    break;
            }
        }
    }
}
