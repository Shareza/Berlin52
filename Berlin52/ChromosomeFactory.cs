using System.Threading;

namespace Berlin52
{
    public class ChromosomeFactory
    {
        public ChromosomeFactory() { }

        public Chromosome[] CreateInitialPopulation(int size)
        {
            var population = new Chromosome[size];

            for(int i = 0; i < size; i ++)
            {
                population[i] = new Chromosome()
                    .Create()
                    .ShuffleGenes();
            }
            return population;
        }
    }
}
