﻿using System;
using System.Diagnostics;

namespace Berlin52
{
    public static class Logger
    {
        static Chromosome fittestEver = new Chromosome
        {
            Fitness = 50000000
        };

        public static void LogToConsole(Population population, int populationNumber, Stopwatch stopWatch)
        {
            var fittestInPopulation = ChromosomeHelper.FindFittest(population.Members);

            if (populationNumber % AppSetting.DisplayRate == 0)
            {
                Console.Clear();

                if (AppSetting.DisplaySetup)
                {
                    Console.WriteLine($"{AppSetting.FitnessCalculatorType}");
                    Console.WriteLine($"{AppSetting.SelectionStrategy.ToString()}");
                    Console.WriteLine($"{AppSetting.CrossoverStrategy.ToString()}");
                    Console.WriteLine($"{AppSetting.MutationStrategy.ToString()}\n");

                    Console.WriteLine($"Population Size: {AppSetting.PopulationSize}");
                    Console.WriteLine($"Selection Rate: {AppSetting.SelectionRate}");
                    Console.WriteLine($"Mutation Rate: {AppSetting.ChromosomeMutationRate}%\n");
                }

                if (AppSetting.DisplayTimer)
                {
                    Console.WriteLine($"Time Elapsed: {stopWatch.Elapsed}");
                }

                Console.WriteLine($"Generation: {populationNumber}");
                Console.WriteLine($"Best in generation: {fittestInPopulation.Fitness}");
                Console.WriteLine($"Best ever: {fittestEver.Fitness}");

                if (fittestInPopulation.Fitness < fittestEver.Fitness)
                {
                    fittestEver.Fitness = fittestInPopulation.Fitness;
                    Array.Copy(fittestInPopulation.Genes, fittestEver.Genes, AppSetting.NumberOfGenes);
                }

                if (AppSetting.DisplayNodes)
                {

                    Console.WriteLine();
                    foreach (var gene in fittestEver.Genes)
                        Console.Write($"{gene}-");
                    Console.Write($"{fittestEver.Fitness}");
                }
            }



                
        }
    }
}