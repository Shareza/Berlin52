﻿using Berlin52.Helpers;
using Berlin52.Interfaces;

namespace Berlin52
{
    public class ScrambleMutationProvider : IMutationProvider
    {
        public void Mutate(Population population)
        {
            for (int i = 0; i < population.Members.Length; i++)
            {
                var mutationProbability = RandomHelper.RandomInt(1, 101);

                if (mutationProbability <= AppSetting.ChromosomeMutationRate)
                {
                    MutationHelper.MutateWithScrambleStrategy(population.Members[i]);
                }
            }
        }
    }
}