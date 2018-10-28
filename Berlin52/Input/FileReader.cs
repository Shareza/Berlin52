using System;
using System.IO;

namespace Berlin52
{
    public class FileReader
    {
        private string FilePath { get; set; }
        public InputData data { get; set; }

        public FileReader(string filePath)
        {
            FilePath = filePath;
        }

        public void GetData ()
        {
            using (StreamReader sr = File.OpenText(FilePath))
            {
                AppSetting.NumberOfGenes = Int32.Parse(sr.ReadLine());
                data = new InputData();
                var line = string.Empty;
                var iterator = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    data.PopulateDistancesTable(line, iterator);
                    iterator++;
                }
            }   
        }
    }
}
