namespace Berlin52
{
    public interface IFitnessCalculatorProvider
    {
        void CalculateFitness(Population population);
        void CalculateFitness(Chromosome chromosome);
    }
}