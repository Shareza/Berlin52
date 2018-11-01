namespace Berlin52.Providers
{
    public class TournamentSelectionProvider : ISelectionProvider
    {
        public void Select(Population population)
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
