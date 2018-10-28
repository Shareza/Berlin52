namespace Berlin52
{
    internal class CrossoverProvider
    {
        private CrossoverType crossoverStrategy;
        private int crossOverRate;

        public CrossoverProvider(CrossoverType crossoverStrategy, int crossOverRate)
        {
            this.crossoverStrategy = crossoverStrategy;
            this.crossOverRate = crossOverRate;
        }

        public void Crossover(Population population)
        {
            return;
        }
    }
}