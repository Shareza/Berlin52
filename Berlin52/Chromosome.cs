using System;
using System.Threading;


namespace Berlin52
{
    public class Chromosome
    {
        public int[] Genes { get; set; }
        public int Fitness { get; set; }
        private Random rnd = new Random();

        public Chromosome()
        {
            Genes = new int[AppSetting.NumberOfGenes];
        }

        public Chromosome Create()
        {
            for(int i = 0; i < AppSetting.NumberOfGenes; i++)
            {
                Genes[i] = i;
            }
            ShuffleGenes();
            return this;
        }

        public Chromosome ShuffleGenes()
        {
            for (int i = 0; i < Genes.Length; i++)
            {
                var random = rnd.Next(AppSetting.NumberOfGenes);
                var temp = Genes[i];
                Genes[i] = Genes[random];
                Genes[random] = temp;
                //fix
                Thread.Sleep(rnd.Next(2));
            }
            var temp2 = Genes[0];
            Genes[0] = Genes[AppSetting.NumberOfGenes -1];
            Genes[AppSetting.NumberOfGenes -1] = temp2;

            return this;
        }
    }
}
