namespace Berlin52
{
    public static class AppSetting
    {
        public static string FilePath = @"..\..\Data.txt";
        public static int NumberOfGenes;

        public static int PopulationSize = 40;

        public static SelectionType selectionStrategy = SelectionType.PMXSelection;
        public static int SelectionRate = 3;

        public static CrossoverType crossoverStrategy = CrossoverType.MultiPointCrossover;
        public static int CrossOverRate = 0;

        public static MutationType mutationStrategy = MutationType.SwapMutation;
        public static int MutationRate = 0;
    }
}
