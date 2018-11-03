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

            for (int i = 0; i <= population.Members.Length - 2;)
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

        public static void CopyGenes(Chromosome source, Chromosome destination)
        {
            Array.Copy(source.Genes, destination.Genes, AppSetting.NumberOfGenes);
        }

        private static Chromosome CreateOffspringWithPMX(Chromosome firstParent, Chromosome secondParent)
        {
            var offspring = new Chromosome();
            Array.Copy(firstParent.Genes, offspring.Genes, AppSetting.NumberOfGenes);

            var firstBorder = RandomHelper.RandomInt(AppSetting.NumberOfGenes);
            var secondBorder = RandomHelper.RandomInt(AppSetting.NumberOfGenes);

            //CopyDNAFromParent(offspring, secondParent, firstBorder, secondBorder);

            return offspring;
        }

        public static void FillGenesWithParentDNA(Offspring offspring, Chromosome parent)
        {
            var j = AppSetting.NumberOfGenes - 1;

            for (int i = AppSetting.NumberOfGenes -1; i >= 0; i--)
            {
                while(offspring.Genes[i] == -1)
                {                   
                    if(parent.Genes[j] != -1)
                    {
                        offspring.Genes[i] = parent.Genes[j];
                    }
                    j--;
                }
            }
        }

        public static void FillGenesWithValue(int[] genes, int v)
        {
            for(int i = 0; i < genes.Length; i++)
            {
                genes[i] = v;
            }
        }

        public static void RemoveGenesFromParent(int[] inheritedGenes, Chromosome secondParent)
        {
            for(int i = 0; i < inheritedGenes.Length; i++)
            {
                var index = Array.IndexOf(secondParent.Genes, inheritedGenes[i]);
                secondParent.Genes[index] = -1;
            }
        }

        public static int[] CopyDNAFromParent(Chromosome parent, int firstCrossingPoint, int secondCrossingPoint)
        {
            if (firstCrossingPoint > secondCrossingPoint)
            {
                var temp = secondCrossingPoint;
                secondCrossingPoint = firstCrossingPoint;
                firstCrossingPoint = temp;
            }

            var genes = new int[secondCrossingPoint - firstCrossingPoint + 1];
            var j = 0;

            for (int i = firstCrossingPoint; i <= secondCrossingPoint; i++)
            {
                genes[j] = parent.Genes[i];
                j++;
            }
            return genes;
        }

        //private static void CopyDNAFromParent(Chromosome offspring, Chromosome parent, int firstBorder, int secondBorder)
        //{
        //    if (firstBorder > secondBorder)
        //    {
        //        var temp = secondBorder;
        //        secondBorder = firstBorder;
        //        firstBorder = temp;
        //    }

        //    for (int i = firstBorder; i <= secondBorder; i++)
        //    {
        //        offspring.Genes[i] = parent.Genes[i];
        //    }
        //}
    }
}