using System;
using System.Collections.Generic;
using System.Linq;
namespace Berlin52
{
    public class Population
    {
        public Chromosome[] Members { get; set; }

        public Population(Chromosome[] members)
        {
            Members = members;
        }

        //public Population CalculateFitness(int[,] distances)
        //{
        //    var fitness = 0;

        //    for (int i = 0; i < AppSetting.PopulationSize; i++)
        //    {
        //        for (int j = 1; j < AppSetting.NumberOfGenes -2; j++)
        //        {
        //            fitness += distances[Members[i].Genes[j], Members[i].Genes[j + 1]];
        //        }
        //        fitness += distances[0, AppSetting.NumberOfGenes -1];
        //        Members[i].Fitness = fitness;
        //        fitness = 0;
        //    }
        //    return this;
        //}

        //public Population Mutate(int mutationRate)
        //{
        //    return this;
        //}

        //public Population CrossOver(int crossoverRate)
        //{
        //    foreach (var member in Members)
        //        Console.WriteLine(member.Fitness);
        //    Console.WriteLine("------------------------");

        //    return this;
        //}

        //public Population PerformSelection(int selectionRate)
        //{
        //    var selected = new Chromosome[AppSetting.PopulationSize];

        //    for(int i = 0; i < AppSetting.PopulationSize; i++)
        //    {
        //        var randomMembers = ChromosomeHelper.GetRandom(selectionRate, Members);
        //        selected[i] = ChromosomeHelper.FindFittest(randomMembers);
        //    }
        //    Members = selected;
        //    return this;
        //}
    }
}
