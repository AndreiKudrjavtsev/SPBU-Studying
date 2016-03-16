using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanModel
{
    class Program
    {
        static void Main(string[] args)
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
            computers[0].InfectionChance = 0.1;
            computers[1].Infected = false;
            computers[1].InfectionChance = 0.02;
            computers[2].Infected = false;
            computers[2].InfectionChance = 0.1;
            Lan lan = new Lan(relationsMatrix, computers);

            lan.RunLanModel();
        }
    }
}
