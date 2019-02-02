using Berlin52.Interfaces;

namespace Berlin52.Factories
{
    public class NoCrossoverProvider : ICrossoverProvider
    {
        public void Crossover(Population population)
        {
            return;
        }
    }
}