namespace Berlin52.Helpers
{
    public static class MutationHelper
    {
        public static void MutateWithSwapStrategy(Chromosome chromosome)
        {
            var firstGene = RandomHelper.RandomInt(chromosome.Genes.Length);
            var secondGene = RandomHelper.RandomInt(chromosome.Genes.Length);

            var temp = chromosome.Genes[firstGene];
            chromosome.Genes[firstGene] = chromosome.Genes[secondGene];
            chromosome.Genes[secondGene] = temp;
        }
    }
}
