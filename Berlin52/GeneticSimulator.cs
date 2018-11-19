using Berlin52.Factories;
using Berlin52.Interfaces;
using System.Diagnostics;

namespace Berlin52
{
    public class GeneticSimulator
    {
        private Population Population;
        private SelectionProviderFactory selectionProviderFactory;
        private CrossoverProviderFactory crossoverProviderFactory;
        private MutationProviderFactory mutationProviderFactory;
        private FitnessCalculatorFactory fitnessCalculatorFactory;
        private Stopwatch StopWatch;

        public GeneticSimulator(Population population, int[,] distances, Stopwatch stopWatch)
        {
            Population = population;
            StopWatch = stopWatch;
            fitnessCalculatorFactory = new FitnessCalculatorFactory(distances);
            selectionProviderFactory = new SelectionProviderFactory();
            crossoverProviderFactory = new CrossoverProviderFactory();
            mutationProviderFactory = new MutationProviderFactory();
        }

        public void Start()
        {
            IFitnessCalculatorProvider fitnessCalculator = fitnessCalculatorFactory.Create();
            ISelectionProvider selectionProvider = selectionProviderFactory.Create();
            ICrossoverProvider crossoverProvider = crossoverProviderFactory.Create();
            IMutationProvider mutationProvider = mutationProviderFactory.Create();

            for (int iteration = 0; iteration < AppSetting.NumberOfIterations; iteration++)
            {
                fitnessCalculator.CalculateFitness(Population);

                Logger.LogToConsole(Population, iteration, StopWatch);

                selectionProvider.Select(Population);

                crossoverProvider.Crossover(Population);

                mutationProvider.Mutate(Population);
            }
        }
    }
}
