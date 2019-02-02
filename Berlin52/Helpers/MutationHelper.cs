using System;
using Berlin52.Entities;

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

        public static void MutateWithScrambleStrategy(Chromosome chromosome)
        {
            var crossingPoints = new CrossingPoints();
            FindCrossingPoints(crossingPoints);

            var length = (crossingPoints.Second - crossingPoints.First) + 1;

            var genesToShuffle = new int[length];
            Array.Copy(chromosome.Genes, crossingPoints.First, genesToShuffle, 0, length);
            ShuffleGenes(genesToShuffle);

            Array.Copy(genesToShuffle, 0, chromosome.Genes, crossingPoints.First, length);
            var newChromosome = new Chromosome { };
            Array.Copy(chromosome.Genes, newChromosome.Genes, AppSetting.NumberOfGenes);
            chromosome = newChromosome;
        }

        private static void ShuffleGenes(int[] genesToShuffle)
        {
            for(int i = 0; i < genesToShuffle.Length;i++)
            {
                int newIndex = RandomHelper.RandomInt(genesToShuffle.Length);
                var temp = genesToShuffle[i];
                genesToShuffle[i] = genesToShuffle[newIndex];
                genesToShuffle[newIndex] = temp;
            }
        }

        private static void FindCrossingPoints(CrossingPoints crossingPoints)
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
            crossingPoints.First = firstCrossingPoint;
            crossingPoints.Second = secondCrossingPoint;
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
