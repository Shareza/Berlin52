﻿using Berlin52.Helpers;

namespace Berlin52
{
    public class Chromosome
    {
        public int[] Genes { get; set; }
        public int Fitness { get; set; }

        public Chromosome()
        {
            Genes = new int[AppSetting.NumberOfGenes];
        }

        public Chromosome(int fitness)
        {
            Fitness = fitness;
        }

        public Chromosome Create()
        {
            for(int i = 0; i < AppSetting.NumberOfGenes; i++)
            {
                Genes[i] = i;
            }
            ShuffleGenes();
            return this;
        }

        public Chromosome ShuffleGenes()
        {
            for (int i = 0; i < Genes.Length; i++)
            {
                var random = RandomHelper.RandomInt(AppSetting.NumberOfGenes);
                var temp = Genes[i];
                Genes[i] = Genes[random];
                Genes[random] = temp;
            }

            var temp2 = Genes[0];
            Genes[0] = Genes[AppSetting.NumberOfGenes -1];
            Genes[AppSetting.NumberOfGenes -1] = temp2;

            return this;
        }

        public void UpdateFitness(int[,] distances)
        {
            var fitness = 0;

            for (int j = 1; j < AppSetting.NumberOfGenes - 2; j++)
            {
                fitness += distances[Genes[j], Genes[j + 1]];
            }
            fitness += distances[0, AppSetting.NumberOfGenes - 1];
            this.Fitness = fitness;
        }
    }
}