using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Berlin52.Helpers
{
    public static class MutationHelper
    {
        public static Chromosome MutateWithSwapStrategy(Chromosome chromosome)
        {
            var random = new Random();

            for(int i = 0; i < chromosome.Genes.Length; i++)
            {
                Thread.Sleep(random.Next(3));
                var mutationProbability = random.Next(0, 101);

                if (mutationProbability <= AppSetting.GeneMutationRate)
                    SwapGenes(chromosome, i);
            }
            return chromosome;
        }

        private static void SwapGenes(Chromosome chromosome, int firstGene)
        {
            var random = new Random();
            var secondGene = random.Next(chromosome.Genes.Length);

            var temp = chromosome.Genes[firstGene];
            chromosome.Genes[firstGene] = chromosome.Genes[secondGene];
            chromosome.Genes[secondGene] = temp;
        }
    }
}
