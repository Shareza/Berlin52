using Berlin52.Interfaces;
using Berlin52.Providers;
using Berlin52.Providers.Crossover;
using System;

namespace Berlin52.Factories
{
    public class CrossoverProviderFactory
    {
        public ICrossoverProvider Create()
        {
            switch (AppSetting.CrossoverStrategy)
            {
                case CrossoverType.None:
                    return new NoCrossoverProvider();

                case CrossoverType.PMXCrossover:
                    return new PMXCrossoverProvider();

                case CrossoverType.OrderedCrossoverWithMultiPoint:
                    return new OXCrossoverWithMultiPointProvider();

                default:
                    throw new ArgumentNullException();
            }
        }
    }
}
