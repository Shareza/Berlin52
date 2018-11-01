using Berlin52.Providers;
using System;

namespace Berlin52.Factories
{
    public class SelectionProviderFactory
    {
        public ISelectionProvider Create()
        {
            switch (AppSetting.SelectionStrategy)
            {
                case SelectionType.TournamentSelection:
                    return new TournamentSelectionProvider();

                case SelectionType.RouletteSelection:
                    return new RouletteSelectionProvider();

                default:
                    throw new ArgumentNullException();
            }
        }
    }
}
