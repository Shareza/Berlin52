using Berlin52.Entities;
using Berlin52.Helpers;
using Berlin52.Interfaces;
using Berlin52.Providers.Crossover;
using System;
using System.Collections.Generic;

namespace Berlin52.Factories
{
    internal class OXCrossoverWithMultiPointProvider : ICrossoverProvider
    {
        public void Crossover(Population population)
        {
            List<Parents> parents = CrossoverHelper.GetParents(population);
            Chromosome[] newMembers = new Chromosome[AppSetting.PopulationSize];
            var temp = AppSetting.PopulationSize - 1;

            for(int i = 0; i < temp; i++)
            {
                var chanceToCrossover = RandomHelper.RandomInt(1, 101);

                if (chanceToCrossover <= AppSetting.CrossOverRate)
                {
                    newMembers[i] = GetOffspring(parents[i].firstParent, parents[i].secondParent);
                    newMembers[temp] = GetOffspring(parents[i].secondParent, parents[i].firstParent);
                }
                else
                {
                    newMembers[i] = parents[i].firstParent;
                    newMembers[temp] = parents[i].secondParent;
                }
                temp--;
            }

            population.Members = newMembers;
        }

        private Chromosome GetOffspring(Chromosome first, Chromosome second)
        {
            var firstParent = new Chromosome();
            var secondParent = new Chromosome();
            CrossoverHelper.CopyGenes(first, firstParent);
            CrossoverHelper.CopyGenes(second, secondParent);

            var firstCrossingPoint = 0;
            var secondCrossingPoint = 0;

            while(firstCrossingPoint == secondCrossingPoint)
            {
                firstCrossingPoint = RandomHelper.RandomInt(AppSetting.NumberOfGenes);
                secondCrossingPoint = RandomHelper.RandomInt(AppSetting.NumberOfGenes);
            }

            var offspring = new Offspring()
            {
                Genes = new int[AppSetting.NumberOfGenes],
                InheritedGenes = CrossoverHelper.CopyDNAFromParent(firstParent, firstCrossingPoint, secondCrossingPoint)
            };
            CrossoverHelper.FillGenesWithValue(offspring.Genes, -1);

            if (firstCrossingPoint > secondCrossingPoint)
            {
                var temp = secondCrossingPoint;
                secondCrossingPoint = firstCrossingPoint;
                firstCrossingPoint = temp;
            }
            Array.Copy(offspring.InheritedGenes, 0, offspring.Genes, firstCrossingPoint, offspring.InheritedGenes.Length);

            CrossoverHelper.RemoveGenesFromParent(offspring.InheritedGenes, secondParent);
            CrossoverHelper.FillGenesWithParentDNA(offspring, secondParent);

            var legalizedOffspring = new Chromosome();
            Array.Copy(offspring.Genes, legalizedOffspring.Genes, AppSetting.NumberOfGenes);

            return legalizedOffspring;
        }

    }
}