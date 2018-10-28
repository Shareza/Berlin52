using System;

namespace Berlin52
{
    public class FitnessProvider
    {
        private int[,] distances;

        public FitnessProvider(int[,] distances)
        {
            this.distances = distances;
        }

        public void CalculateFitness(Population population)
        {
            var fitness = 0;

            for (int i = 0; i < AppSetting.PopulationSize; i++)
            {
                for (int j = 1; j < AppSetting.NumberOfGenes - 2; j++)
                {
                    fitness += distances[population.Members[i].Genes[j], population.Members[i].Genes[j + 1]];
                }
                fitness += distances[0, AppSetting.NumberOfGenes - 1];
                population.Members[i].Fitness = fitness;
                fitness = 0;
            }
        }
    }
}