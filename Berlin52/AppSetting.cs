namespace Berlin52
{
    public static class AppSetting
    {
        public static string FilePath = @"..\..\Data.txt";
        public static int NumberOfGenes;

        public static int PopulationSize = 100;
        public static long NumberOfIterations = 1000000;

        public static SelectionType SelectionStrategy = SelectionType.TournamentSelection;
        public static int SelectionRate = 5;

        public static CrossoverType CrossoverStrategy = CrossoverType.MultiPointCrossover;
        public static int CrossOverRate = 0;

        public static MutationType MutationStrategy = MutationType.SwapMutation;
        public static int ChromosomeMutationRate = 15;
    }
}
