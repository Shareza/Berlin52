namespace Berlin52
{
    public class GeneticSimulator
    {
        private Population Population;
        private int[,] Distances;
        private int PopulationNumber { get; set; }

        public GeneticSimulator(Population population, int[,] distances)
        {
            Population = population;
            Distances = distances;
            PopulationNumber = 0;
        }

        public void Start()
        {
            var fitnessProvider = new FitnessProvider(Distances);
            var selectionProvider = new SelectionProvider();
            var crossoverProvider = new CrossoverProvider();
            var mutationProvider = new MutationProvider(Distances);

            while(AppSetting.NumberOfIterations > 0)
            {       
                fitnessProvider.CalculateFitness(Population);

                selectionProvider.Select(Population);

                crossoverProvider.Crossover(Population);

                mutationProvider.Mutate(Population);

                Logger.LogToConsole(Population, PopulationNumber);
                PopulationNumber++;
                AppSetting.NumberOfIterations--;
            }
        }
    }
}
