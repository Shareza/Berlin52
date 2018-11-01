using Berlin52.Interfaces;
using Berlin52.Providers;
using System;

namespace Berlin52.Factories
{
    public class CrossoverProviderFactory
    {
        public ICrossoverProvider Create()
        {
            switch (AppSetting.CrossoverStrategy)
            {
                case CrossoverType.SinglePointCrossover:
                    return new SinglePointCrossoverProvider();

                case CrossoverType.MultiPointCrossover:
                    return new MultiPointCrossoverProvider();

                default:
                    throw new ArgumentNullException();
            }
        }
    }
}
