using System;
using System.Diagnostics;

namespace Berlin52
{
    public static class Logger
    {
        static int fittestEver = 50000000;

        public static void LogToConsole(Population population, int populationNumber, Stopwatch stopWatch)
        {
            var fittestInPopulation = ChromosomeHelper.FindFittest(population.Members);

            Console.Clear();

            Console.WriteLine($"{AppSetting.FitnessCalculatorType}");
            Console.WriteLine($"{AppSetting.SelectionStrategy.ToString()}");
            Console.WriteLine($"{AppSetting.CrossoverStrategy.ToString()}");
            if (AppSetting.SingleGeneMutation == true)
                Console.WriteLine($"Single Gene Mutation");
            else
                Console.WriteLine($"Multi Gene Mutation");

            Console.WriteLine($"{AppSetting.MutationStrategy.ToString()}\n");

            Console.WriteLine($"Population Size: {AppSetting.PopulationSize}");
            Console.WriteLine($"Selection Rate: {AppSetting.SelectionRate}");
            Console.WriteLine($"Mutation Rate: {AppSetting.ChromosomeMutationRate}%\n");

            Console.WriteLine($"Time Elapsed: {stopWatch.Elapsed}");
            Console.WriteLine($"Generation: {populationNumber}");
            Console.WriteLine($"Best Score: {fittestInPopulation.Fitness}");

            if (fittestInPopulation.Fitness < fittestEver)
                fittestEver = fittestInPopulation.Fitness;

            Console.WriteLine($"Fittest: {fittestEver}");
            Console.WriteLine();
                foreach (var gene in fittestInPopulation.Genes)
                    Console.Write($"{gene}-");
            Console.Write($"{fittestInPopulation.Fitness}");



                
        }
    }
}