using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berlin52.Helpers
{
    public static class RandomHelper
    {
        private static readonly Random Random = new Random();

        public static int RandomInt(int maxValue = int.MaxValue)
        {
            return Random.Next(maxValue);
        }
        public static int RandomInt(int minValue, int maxValue)
        {
            return Random.Next(minValue, maxValue);
        }
    }
}
