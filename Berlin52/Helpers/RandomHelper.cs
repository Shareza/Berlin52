using System;

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

        public static bool RandomBool()
        {
            return Random.Next() % 2 == 0;
        }
    }
}
