using System;
using System.Diagnostics;

namespace Berlin52
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            FileReader reader = new FileReader(AppSetting.FilePath);
            reader.GetData();

            ChromosomeFactory chromosomeFactory = new ChromosomeFactory();
            var members = chromosomeFactory.CreateInitialPopulation(AppSetting.PopulationSize);

            Population population = new Population(members);

            GeneticSimulator simulation = new GeneticSimulator(population, reader.data.Distances, stopWatch);
            simulation.Start();

            Console.ReadKey();
        }
    }
}
