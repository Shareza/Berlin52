using System;
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

        public GeneticSimulator(Population population, int[,] distances)
        {
            this.Population = population;
            this.Distances = distances;
        }

        public void Start()
        {
            //fix true
            while(true)
            {
                Population
                    .CalculateFitness(Distances)
                    .PerformSelection(AppSetting.SelectionRate)
                    .CrossOver(AppSetting.CrossOverRate)
                    .Mutate(AppSetting.MutationRate);
            }
        }
    }
}
