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
            var temp = new Chromosome(50000);

            for(int i = 0; i < randomMembers.Length; i++)
            {
                if (randomMembers[i].Fitness < temp.Fitness)
                    temp = randomMembers[i];
            }

            var fittest = new Chromosome()
            {
                Fitness = temp.Fitness
            };

            Array.Copy(temp.Genes, fittest.Genes, AppSetting.NumberOfGenes);
            return fittest;
        }
    }
}
