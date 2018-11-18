using System;

namespace Berlin52
{
    public static class Logger
    {
        static int fittestEver = 50000000;

        public static void LogToConsole(Population population, int populationNumber)
        {
            var fittestInPopulation = ChromosomeHelper.FindFittest(population.Members);

            Console.Clear();
            Console.WriteLine($"Population Size: {AppSetting.PopulationSize}");
            Console.WriteLine();
            Console.WriteLine($"Using: {AppSetting.FitnessCalculatorType}");
            Console.WriteLine();
            Console.WriteLine($"Using: {AppSetting.SelectionStrategy.ToString()}");
            Console.WriteLine($"Selection Rate: {AppSetting.SelectionRate}");
            Console.WriteLine();
            Console.WriteLine($"Using {AppSetting.CrossoverStrategy.ToString()}");
            Console.WriteLine();
            Console.WriteLine($"Using {AppSetting.MutationStrategy.ToString()}");
            Console.WriteLine($"Mutation Rate: {AppSetting.ChromosomeMutationRate}%");
            if(AppSetting.SingleGeneMutation == true)
                Console.WriteLine($"Single Gene Mutation");
            else
                Console.WriteLine($"Multi Gene Mutation");

            Console.WriteLine();
            Console.WriteLine($"Population: {populationNumber}");
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