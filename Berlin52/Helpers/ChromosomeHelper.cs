using Berlin52.Helpers;
using System;

namespace Berlin52
{
    public static class ChromosomeHelper
    {
        public static Chromosome[] GetRandom(int selectionRate, Chromosome[] members)
        {
            var randomChromosomes = new Chromosome[selectionRate];

            for(int i = 0; i < selectionRate; i++)
            {
                var rnd = RandomHelper.RandomInt(AppSetting.PopulationSize);
                randomChromosomes[i] = members[rnd];
            }
            return randomChromosomes;
        }

        internal static Chromosome FindFittest(Chromosome[] randomMembers)
        {
            var fittest = new Chromosome(50000);

            for(int i = 0; i < randomMembers.Length; i++)
            {
                if (randomMembers[i].Fitness < fittest.Fitness)
                    fittest = randomMembers[i];
            }

            var test = new Chromosome()
            {
                Fitness = fittest.Fitness
            };

            Array.Copy(fittest.Genes, test.Genes, AppSetting.NumberOfGenes);
            return test;
        }
    }
}
