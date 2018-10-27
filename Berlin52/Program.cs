using System;
using System.Diagnostics;

namespace Berlin52
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            FileReader reader = new FileReader(AppSetting.FilePath);
            reader.GetData();

            ChromosomeFactory chromosomeFactory = new ChromosomeFactory();
            var members = chromosomeFactory.CreateInitialPopulation(AppSetting.PopulationSize);

            Population population = new Population(members);

            GeneticSimulator simulation = new GeneticSimulator(population, reader.data.Distances);
            simulation.Start();

            //initialPopulation.CalculateFitness(reader.data.Distances);



            stopwatch.Stop();

            foreach (var member in population.Members)
                Console.WriteLine(member.Fitness);

            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");
            Console.ReadKey();
        }
    }
}
