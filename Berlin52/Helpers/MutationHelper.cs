namespace Berlin52.Helpers
{
    public static class MutationHelper
    {
        public static void MutateWithSwapStrategy(Chromosome chromosome)
        {
            var firstGene = RandomHelper.RandomInt(0, AppSetting.NumberOfGenes);
            var secondGene = RandomHelper.RandomInt(0, AppSetting.NumberOfGenes);

            var temp = chromosome.Genes[firstGene];
            chromosome.Genes[firstGene] = chromosome.Genes[secondGene];
            chromosome.Genes[secondGene] = temp;
        }
    }
}
