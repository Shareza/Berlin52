using System;

namespace Berlin52
{
    public class SelectionProvider
    {
        public void Select(Population population)
        {
            switch(AppSetting.SelectionStrategy)
            {
                case SelectionType.TournamentSelection:
                    TournamentSelection(population);
                    break;
                case SelectionType.RouletteSelection:
                    RouletteSelection(population);
                    break;
            }
        }

        private void RouletteSelection(Population population)
        {
            throw new NotImplementedException();
        }

        private void TournamentSelection(Population population)
        {
            var selected = new Chromosome[AppSetting.PopulationSize];

            for (int i = 0; i < AppSetting.PopulationSize; i++)
            {
                var randomMembers = ChromosomeHelper.GetRandom(AppSetting.SelectionRate, population.Members);
                selected[i] = ChromosomeHelper.FindFittest(randomMembers);
            }
            population.Members = selected;
        }
    }
}