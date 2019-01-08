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
                case MutationType.SwapMutation:
                    return new SwapMutationProvider();

                case MutationType.InversionMutation:
                    return new InversionMutationProvider();

                default:
                    throw new ArgumentNullException();
            }
        }
    }
}