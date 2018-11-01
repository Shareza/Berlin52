namespace Berlin52
{
    public class DefaultFitnessCalculatorProvider : IFitnessCalculatorProvider
    {
        private int[,] Distances;

        public DefaultFitnessCalculatorProvider(int[,] distances)
        {
            Distances = distances;
        }

        public void CalculateFitness(Population population)
        {
            var fitness = 0;

            for (int i = 0; i < AppSetting.PopulationSize; i++)
            {
                for (int j = 1; j < AppSetting.NumberOfGenes - 2; j++)
                {
                    fitness += Distances[population.Members[i].Genes[j], population.Members[i].Genes[j + 1]];
                }
                fitness += Distances[0, AppSetting.NumberOfGenes - 1];
                population.Members[i].Fitness = fitness;
                fitness = 0;
            }
        }

        public void CalculateFitness(Chromosome chromosome)
        {
            var fitness = 0;

            for (int j = 1; j < AppSetting.NumberOfGenes - 2; j++)
            {
                fitness += Distances[chromosome.Genes[j], chromosome.Genes[j + 1]];
            }
            fitness += Distances[0, AppSetting.NumberOfGenes - 1];
            chromosome.Fitness = fitness;
        }
    }
}