using System;

namespace Berlin52
{
    public static class Logger
    {
        public static void LogToConsole(Population population, int populationNumber)
        {
            var fittest = ChromosomeHelper.FindFittest(population.Members);

            Console.Clear();
            Console.WriteLine($"Population: {populationNumber}");
            Console.WriteLine($"Best Score: {fittest.Fitness}");
        }
    }
}