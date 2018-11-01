using Berlin52.Entities;
using Berlin52.Interfaces;
using System.Collections.Generic;

namespace Berlin52.Providers.Crossover
{
    public class PMXCrossoverProvider : ICrossoverProvider
    {
        public void Crossover(Population population)
        {
            List<Parents> parents = CrossoverHelper.GetParents(population);
            Chromosome[] newMembers = new Chromosome[AppSetting.PopulationSize];

            for(int i = 0; i < parents.Count; i++)
            {
                Chromosome[] offsprings = CrossoverHelper.CrossoverWithPMX(parents[i]);

                newMembers[i] = offsprings[0];
                newMembers[i + 1] = offsprings[1];
            }
            population.Members = newMembers;
        }
    }
}
