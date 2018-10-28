using System;
using System.Threading;
using Berlin52.Helpers;

namespace Berlin52
{
    public class MutationProvider
    {
        private MutationType MutationStrategy;
        private int ChromosomeMutationRate;
        private int GeneMutationRate;
        private Random Random;
        private int[,] Distances;

        public MutationProvider(MutationType mutationStrategy, int geneMutationRate, int chromosomeMutationRate, int[,] distances)
        {
            MutationStrategy = mutationStrategy;
            ChromosomeMutationRate = chromosomeMutationRate;
            GeneMutationRate = geneMutationRate;
            Distances = distances;
        }

        public void Mutate(Population population)
        {
            switch(MutationStrategy)
            {
                case MutationType.SwapMutation:
                    SwapMutation(population);
                    break;
            }
        }

        private void SwapMutation(Population population)
        {
            Random = new Random();

            for(int i = 0; i < population.Members.Length; i++)
            {
                Thread.Sleep(Random.Next(2));
                var mutationProbability = Random.Next(0, 101);

                if (mutationProbability <= ChromosomeMutationRate)
                {
                    int fitness = population.Members[i].Fitness;

                    var mutated = MutationHelper.MutateWithSwapStrategy(population.Members[i]);
                    mutated.UpdateFitness(Distances);

                    if (mutated.Fitness < fitness)
                        population.Members[i] = mutated;
                }
            }
        }
    }
}