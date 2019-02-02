using Berlin52.Enums;

namespace Berlin52
{
    public static class AppSetting
    {
        public static string FilePath = @"..\..\berlin52.txt";
        public static int NumberOfGenes;
        public static bool DisplaySetup = false;
        public static bool DisplayTimer = false;
        public static bool DisplayNodes = true;
        public static int DisplayRate = 1000;

        public static int PopulationSize = 40; //Population size needs to be even number
        public static long NumberOfIterations = 1000000;
        public static FitnessCalculatorType FitnessCalculatorType = FitnessCalculatorType.DefaultFitnessCalculator;

        public static SelectionType SelectionStrategy = SelectionType.TournamentSelection;
        public static int SelectionRate = 3;

        public static CrossoverType CrossoverStrategy = CrossoverType.OrderedCrossoverWithMultiPoint;
        public static int CrossOverRate = 75;

        public static MutationType MutationStrategy = MutationType.InversionMutation;
        public static int ChromosomeMutationRate = 35;

        // Applies to SwapMutation only
        public static int GeneMutationRate = 3;
    }
}
