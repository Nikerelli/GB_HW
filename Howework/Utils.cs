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

        public static void DisplayArray(this double[][] arr)
        {
            Console.Write("{0,-9}", "Column");
            for (int i = 1; i <= arr[0].Length; i++)
            {
                Console.Write($"{i,-8}");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\n#{0,-8}", i + 1);
                for (int j = 0; j < arr[0].Length; j++)
                {
                    Console.Write($"{arr[i][j],-8:#0.0}" );
                }
            }
        }
        public static void DisplayArray(this int[][] arr)
        {
            Console.Write("{0,-9}", "Column");
            for (int i = 1; i <= arr[0].Length; i++)
            {
                Console.Write($"{i,-8}");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\n#{0,-8}", i + 1);
                for (int j = 0; j < arr[0].Length; j++)
                {
                    Console.Write($"{arr[i][j],-8}" );
                }
            }
        }
        
    }
}
