using System;

namespace Howework
{
    public static class HW7
    {
        public static double[][] Task49(int m, int n)
        {
            var arr = new double[m][];
            var rd = new Random();
            for (int i = 0; i < m; i++)
            {
                arr[i] = new double[n];
                for (int j = 0; j < n; j++)
                {
                    arr[i][j] = rd.NextDouble() * rd.Next(10,100);
                }
            }

            arr.DisplayArray();
            
            return arr;
        }

        public static int[][] Task51(int m, int n)
        {
            var arr = new int[m][];
            for (int i = 0; i < m; i++)
            {
                arr[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    arr[i][j] = i + j;
                }
            }

            arr.DisplayArray();
            
            return arr;
        }

        public static void Task53(int m, int n)
        {
            var arr = Task51(m,n);
            Console.Write("\n");
            if (int.TryParse(Console.ReadLine(), out int searchVal))
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (arr[i][j] == searchVal)
                        {
                            Console.WriteLine($"arr[{i}][{j}] = {searchVal}");
                        }
                    }
                }
            }
            else
            {
                throw new ArgumentException("Not integer value was passed");
            }
        }

        public static void Task55(int m, int n)
        {
            var arr = Task49(m,n);
            var medians = new double[arr.Length];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    medians[i] = (medians[i] + arr[i][j]) / 2;
                }
            }

            for(int i = 0; i < medians.Length; i++)
            {
                Console.Write($"\nRow #{i + 1} median = {medians[i]:#.#}");
            }
        }
    }
}