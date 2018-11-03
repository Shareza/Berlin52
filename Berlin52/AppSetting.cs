using Berlin52.Enums;

namespace Berlin52
{
    public static class AppSetting
    {
        public static string FilePath = @"..\..\Data.txt";
        public static int NumberOfGenes;

        public static int PopulationSize = 10000; //Population size needs to be even number
        public static long NumberOfIterations = 1000000;
        public static FitnessCalculatorType FitnessCalculatorType = FitnessCalculatorType.DefaultFitnessCalculator;

        public static SelectionType SelectionStrategy = SelectionType.TournamentSelection;
        public static int SelectionRate = 15;

        public static CrossoverType CrossoverStrategy = CrossoverType.OrderedCrossoverWithMultiPoint;
        public static int CrossOverRate = 0;

        public static MutationType MutationStrategy = MutationType.SwapMutation;
        public static int ChromosomeMutationRate = 5;
        public static bool SingleGeneMutation = true;
        public static bool MultiGeneMutation = false;
    }
}
