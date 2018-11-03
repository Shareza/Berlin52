using Berlin52.Enums;
using System;

namespace Berlin52
{
    public class FitnessCalculatorFactory
    {
        private int[,] Distances;

        public FitnessCalculatorFactory(int[,] distances)
        {
            Distances = distances;
        }

        public IFitnessCalculatorProvider Create()
        {
            switch(AppSetting.FitnessCalculatorType)
            {
                case FitnessCalculatorType.DefaultFitnessCalculator:
                    return new DefaultFitnessCalculatorProvider(Distances);

                default:
                    throw new ArgumentNullException();
            }
        }
    }
}