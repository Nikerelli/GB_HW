using System;

namespace Howework
{
    public static class Utils
    {
        public static int[] FillGeneratedValues(this int[] arr, int minBound = 0, int maxBoud = 10)
        {
            if(minBound > maxBoud)
            {
                throw new ArgumentException($"{nameof(minBound)} cannot be less than {nameof(maxBoud)}");
            }

            var rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(minBound, maxBoud);
            }

            return arr;
        }

        public static double[] FillGeneratedValues(this double[] arr, int minBound = 0, int maxBoud = 10)
        {
            if (minBound > maxBoud)
            {
                throw new ArgumentException($"{nameof(minBound)} cannot be less than {nameof(maxBoud)}");
            }

            var rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.NextDouble() * rd.Next(minBound, maxBoud);
            }

            return arr;
        }
    }
}
