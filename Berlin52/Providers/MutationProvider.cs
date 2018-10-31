using Berlin52.Helpers;
using System;

namespace Berlin52
{
    public class MutationProvider
    {
        private int[,] Distances;

        public MutationProvider(int[,] distances)
        {
            Distances = distances;
        }

        public void Mutate(Population population)
        {
            switch(AppSetting.MutationStrategy)
            {
                case MutationType.SwapMutation:
                    SwapMutation(population);
                    break;
            }
        }

        private void SwapMutation(Population population)
        {
            var mutatedCount = 0;

            for (int i = 0; i < population.Members.Length; i++)
            {
                var mutationProbability = RandomHelper.RandomInt(1, 101);

                if (mutationProbability <= AppSetting.ChromosomeMutationRate)
                {
                    MutationHelper.MutateWithSwapStrategy(population.Members[i]);
                    mutatedCount++;
                } 
            }
        }
    }
}