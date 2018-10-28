using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berlin52.Helpers
{
    public static class MutationHelper
    {
        private static Random random;

        public static void MutateWithSwapStrategy(Chromosome chromosome)
        {
            random = new Random();

            for(int i = 0; i < chromosome.Genes.Length; i++)
            {
                var mutationProbability = random.Next(100);

                if (mutationProbability <= AppSetting.MutationRate)
                    SwapGenes(chromosome, i);
            }
        }

        private static void SwapGenes(Chromosome chromosome, int firstGene)
        {
            var secondGene = random.Next(chromosome.Genes.Length);

            var temp = chromosome.Genes[firstGene];
            chromosome.Genes[firstGene] = chromosome.Genes[secondGene];
            chromosome.Genes[secondGene] = temp;
        }
    }
}
