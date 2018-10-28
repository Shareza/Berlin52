using System;
using Berlin52.Helpers;

namespace Berlin52
{
    public class MutationProvider
    {
        private MutationType mutationStrategy;
        private int mutationRate;
        private Random random;

        public MutationProvider(MutationType mutationStrategy, int mutationRate)
        {
            this.mutationStrategy = mutationStrategy;
            this.mutationRate = mutationRate;
        }

        public void Mutate(Population population)
        {
            switch(mutationStrategy)
            {
                case MutationType.SwapMutation:
                    SwapMutation(population);
                    break;
            }
        }

        private void SwapMutation(Population population)
        {
            random = new Random();

            for(int i = 0; i < population.Members.Length; i++)
            {
                var mutationProbability = random.Next(100);

                if (mutationProbability <= mutationRate)
                {
                    var member = population.Members[i];

                    MutationHelper.MutateWithSwapStrategy(member);

                    if (member.Fitness > population.Members[i].Fitness)
                        population.Members[i] = member;
                }
            }
        }
    }
}