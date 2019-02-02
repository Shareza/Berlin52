using Berlin52.Interfaces;
using System;

namespace Berlin52
{
    public class MutationProviderFactory
    {
        public IMutationProvider Create()
        {
            switch(AppSetting.MutationStrategy)
            {
                case MutationType.None:
                return new NoMutationProvider();

                case MutationType.SwapMutation:
                    return new SwapMutationProvider();

                case MutationType.InversionMutation:
                    return new InversionMutationProvider();

                case MutationType.ScrambleMutation:
                    return new ScrambleMutationProvider();

                default:
                    throw new ArgumentNullException();
            }
        }
    }
}