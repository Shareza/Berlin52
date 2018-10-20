using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berlin52
{
    public class Population
    {
        public Chromosome[] Members { get; set; }

        public Population(Chromosome[] members)
        {
            Members = members;
        }

        public void CalculateFitness(int[,] distances)
        {
            var fitness = 0;

            for (int i = 0; i < AppSetting.PopulationSize; i++)
            {
                for (int j = 1; j < AppSetting.NumberOfGenes -2; j++)
                {
                    fitness += distances[Members[i].Genes[j], Members[i].Genes[j + 1]];
                }
                fitness += distances[0, AppSetting.NumberOfGenes -1];
                Members[i].Fitness = fitness;
                fitness = 0;
            }
        }
    }
}
