using System;

namespace Berlin52.Helpers
{
    public static class MutationHelper
    {
        public static void MutateWithSwapStrategy(Chromosome chromosome)
        {
            for (int i = 0; i < chromosome.Genes.Length; i++)
            {
                var geneMutationChance = RandomHelper.RandomInt(1, 101);

                if (geneMutationChance <= AppSetting.GeneMutationRate)
                {
                    var firstGeneIndex = i;
                    var secondGeneIndex = RandomHelper.RandomInt(0, AppSetting.NumberOfGenes);

                    var temp = chromosome.Genes[firstGeneIndex];
                    chromosome.Genes[firstGeneIndex] = chromosome.Genes[secondGeneIndex];
                    chromosome.Genes[secondGeneIndex] = temp;
                }
            }
        }

        public static void MutateWithInversionStrategy(Chromosome chromosome)
        {
            var firstCrossingPoint = 0;
            var secondCrossingPoint = 0;
            var length = 0;

            while (firstCrossingPoint == secondCrossingPoint)
            {
                firstCrossingPoint = RandomHelper.RandomInt(AppSetting.NumberOfGenes);
                secondCrossingPoint = RandomHelper.RandomInt(AppSetting.NumberOfGenes);
            }

            if (firstCrossingPoint > secondCrossingPoint)
            {
                var temp = secondCrossingPoint;
                secondCrossingPoint = firstCrossingPoint;
                firstCrossingPoint = temp;
            }

            length = 1 + (secondCrossingPoint - firstCrossingPoint);
            Array.Reverse(chromosome.Genes, firstCrossingPoint, length);
        }
    }
}
