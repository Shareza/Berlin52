using System;

namespace Berlin52
{
    public class InputData
    {
        public int[,] Distances { get; set; }

        public InputData()
        {
            Distances = new int[AppSetting.NumberOfGenes, AppSetting.NumberOfGenes];
        }

        public void PopulateDistancesTable(string line, int iterator)
        {
            string[] items = line.Split(' ');
            //fix later
            Array.Resize(ref items, items.Length - 1);

            for(int i = 0; i < items.Length; i++)
            {
                Distances[iterator, i] = Int32.Parse(items[i]);
                Distances[i, iterator] = Int32.Parse(items[i]);
            }
        }
    }
}
