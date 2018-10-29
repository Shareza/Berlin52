using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Berlin52.Helpers;

namespace Berlin52
{
    public static class ChromosomeHelper
    {
        //private static Random random;

        public static Chromosome[] GetRandom(int selectionRate, Chromosome[] members)
        {
           // random = new Random();
            var randomChromosomes = new Chromosome[selectionRate];

            for(int i = 0; i < selectionRate; i++)
            {
                //var rnd = random.Next(AppSetting.PopulationSize);
                var rnd = RandomHelper.RandomInt(AppSetting.PopulationSize);
                //Thread.Sleep(random.Next(3));
                randomChromosomes[i] = members[rnd];
            }
            return randomChromosomes;
        }

        internal static Chromosome FindFittest(Chromosome[] randomMembers)
        {
            var fittest = new Chromosome(50000);

            for(int i = 0; i < randomMembers.Length; i++)
            {
                if (randomMembers[i].Fitness < fittest.Fitness)
                    fittest = randomMembers[i];
            }
            return fittest;
        }
    }
}
