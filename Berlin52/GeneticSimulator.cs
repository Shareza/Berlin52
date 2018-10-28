﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berlin52
{
    public class GeneticSimulator
    {
        private Population Population;
        private int[,] Distances;
        private int PopulationNumber { get; set; }

        public GeneticSimulator(Population population, int[,] distances)
        {
            Population = population;
            Distances = distances;
            PopulationNumber = 0;
        }

        public void Start()
        {
            var fitnessProvider = new FitnessProvider(Distances);
            var selectionProvider = new SelectionProvider(AppSetting.SelectionStrategy, AppSetting.SelectionRate);
            var crossoverProvider = new CrossoverProvider(AppSetting.CrossoverStrategy, AppSetting.CrossOverRate);
            var mutationProvider = new MutationProvider(AppSetting.MutationStrategy, AppSetting.GeneMutationRate, AppSetting.ChromosomeMutationRate, Distances);

            while(AppSetting.NumberOfIterations > 0)
            {
                Logger.LogToConsole(Population, PopulationNumber);

                fitnessProvider.CalculateFitness(Population);

                selectionProvider.Select(Population);

                crossoverProvider.Crossover(Population);

                mutationProvider.Mutate(Population);

                PopulationNumber++;
                AppSetting.NumberOfIterations--;
            }
        }
    }
}
