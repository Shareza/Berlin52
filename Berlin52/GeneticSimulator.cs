using System.Threading;

namespace Berlin52
{
    public class GeneticSimulator
    {
        private Population Population;
        private int[,] Distances;

        public GeneticSimulator(Population population, int[,] distances)
        {
            Population = population;
            Distances = distances;
        }

        public void Start()
        {
            var fitnessProvider = new FitnessProvider(Distances);
            var selectionProvider = new SelectionProvider();
            var crossoverProvider = new CrossoverProvider();
            var mutationProvider = new MutationProvider(Distances);

            for (int iteration = 0; iteration < AppSetting.NumberOfIterations; iteration++)
            {
                fitnessProvider.CalculateFitness(Population);

                selectionProvider.Select(Population);

                crossoverProvider.Crossover(Population);

                mutationProvider.Mutate(Population);

                Logger.LogToConsole(Population, iteration);
                Thread.Sleep(5);
            }
        }
    }
}
