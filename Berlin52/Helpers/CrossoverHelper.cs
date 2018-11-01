using System;
using System.Collections.Generic;
using Berlin52.Entities;
using Berlin52.Helpers;

namespace Berlin52.Providers.Crossover
{
    public class CrossoverHelper
    {
        public static List<Parents> GetParents(Population population)
        {
            var parents = new List<Parents>();

            for(int i = 0; i <= population.Members.Length -2 ;)
            {
                var couple = new Parents()
                {
                    firstParent = new Chromosome(),
                    secondParent = new Chromosome()
                };
                Array.Copy(population.Members[i].Genes, couple.firstParent.Genes, AppSetting.NumberOfGenes);
                Array.Copy(population.Members[i + 1].Genes, couple.secondParent.Genes, AppSetting.NumberOfGenes);

                parents.Add(couple);

                i += 2;
            }
            return parents;
        }

        public static Chromosome[] CrossoverWithPMX(Parents parents)
        {
            var offsprings = new Chromosome[2];

            offsprings[0] = CreateOffspringWithPMX(parents.firstParent, parents.secondParent);
            offsprings[1] = CreateOffspringWithPMX(parents.secondParent, parents.firstParent);

            return offsprings;
        }

        private static Chromosome CreateOffspringWithPMX(Chromosome firstParent, Chromosome secondParent)
        {
            var offspring = new Chromosome();
            var firstBorder = RandomHelper.RandomInt(AppSetting.NumberOfGenes);
            var secondBorder = RandomHelper.RandomInt(AppSetting.NumberOfGenes);



            return offspring;
        }
    }
}