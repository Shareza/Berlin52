namespace Berlin52
{
    internal class MutationProvider
    {
        private MutationType mutationStrategy;
        private int mutationRate;

        public MutationProvider(MutationType mutationStrategy, int mutationRate)
        {
            this.mutationStrategy = mutationStrategy;
            this.mutationRate = mutationRate;
        }

        public void Mutate(Population population)
        {
            return;
        }
    }
}