namespace Berlin52
{
    public static class AppSetting
    {
        public static string FilePath = @"..\..\Data.txt";
        public static int NumberOfGenes;

        public static int PopulationSize = 40;
        public static long NumberOfIterations = 100000;

        public static SelectionType SelectionStrategy = SelectionType.PMXSelection;
        public static int SelectionRate = 3;

        public static CrossoverType CrossoverStrategy = CrossoverType.MultiPointCrossover;
        public static int CrossOverRate = 0;

        public static MutationType MutationStrategy = MutationType.SwapMutation;
        public static int MutationRate = 20;
    }
}
