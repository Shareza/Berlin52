using System;

namespace Berlin52
{
    public class SelectionProvider
    {
        private SelectionType selectionStrategy;
        private int selectionRate;

        public SelectionProvider(SelectionType selectionStrategy, int selectionRate)
        {
            this.selectionStrategy = selectionStrategy;
            this.selectionRate = selectionRate;
        }

        public void Select(Population population)
        {
            switch(selectionStrategy)
            {
                case SelectionType.PMXSelection:
                    PMXSelection(population);
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

        private void PMXSelection(Population population)
        {
            var selected = new Chromosome[AppSetting.PopulationSize];

            for (int i = 0; i < AppSetting.PopulationSize; i++)
            {
                var randomMembers = ChromosomeHelper.GetRandom(selectionRate, population.Members);
                selected[i] = ChromosomeHelper.FindFittest(randomMembers);
            }
            population.Members = selected;
        }
    }
}