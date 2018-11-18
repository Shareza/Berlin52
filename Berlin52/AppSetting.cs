using Berlin52.Enums;

namespace Berlin52
{
    public static class AppSetting
    {
        public static string FilePath = @"..\..\ulysses16.txt";
        public static int NumberOfGenes;

        public static int PopulationSize = 1000; //Population size needs to be even number
        public static long NumberOfIterations = 1000000;
        public static FitnessCalculatorType FitnessCalculatorType = FitnessCalculatorType.DefaultFitnessCalculator;

        public static SelectionType SelectionStrategy = SelectionType.TournamentSelection;
        public static int SelectionRate = 3;

        public static CrossoverType CrossoverStrategy = CrossoverType.OrderedCrossoverWithMultiPoint;
        public static int CrossOverRate = 0;

        public static MutationType MutationStrategy = MutationType.SwapMutation;
        public static int ChromosomeMutationRate = 15;
        public static bool SingleGeneMutation = false;
    }
}
