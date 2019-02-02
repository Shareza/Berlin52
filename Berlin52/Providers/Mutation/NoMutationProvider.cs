using Berlin52.Interfaces;

namespace Berlin52
{
    public class NoMutationProvider : IMutationProvider
    {
        public void Mutate(Population population)
        {
            return;
        }
    }
}