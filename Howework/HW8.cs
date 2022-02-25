using System;
using System.Linq;
using System.Text;

namespace Howework
{
    public static class HW8
    {
        public static void Task57(int[][] arr)
        {
            Console.WriteLine("Source array:");
            arr.DisplayArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Array.Sort(arr[i]);
                arr[i] = arr[i]
                    .Reverse()
                    .ToArray();
            }
            Console.WriteLine("\nResult array:");
            arr.DisplayArray();
        }

        public static void Task59(int[][] arr)
        {
            int minSum = arr[0].Sum();
            int index = 0;
            Console.Write($"{"Row #",-8}");
            var sb = new StringBuilder($"{"Value",-8}");
            for (int i = 1; i < arr.Length; i++)
            {
                var currSum = arr[i].Sum();
                Console.Write($"{i, 8}");
                sb.Append($"{currSum,8}");
                if (minSum > currSum)
                {
                    index = i;
                    minSum = currSum;
                }
            }
            Console.WriteLine($"\n{sb}");
            Console.WriteLine($"Min sum = {minSum} found at row #{index}");
        }

        public static void Task61()
        {
            var size = 4;
            var startVal = 10;
            var arr = new int[size][][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[size][];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = new int[size];
                    for (int k = 0; k < arr[i][j].Length; k++)
                    {
                        arr[i][j][k] = startVal++;
                        Console.WriteLine("{0,15}", $"{i}:{j}:{k} = {arr[i][j][k]}");
                    }
                }
            }
        }

        public static void Task63()
        {
            var size = 5;
            var arr = new int[size][];
            int i = 0;
            for (; i < size; i++)
            {
                arr[i] = new int[size].FillGeneratedValues();
            }

            int val = 1;
            int j = 0;
            i = 0;
            while (val <= arr.Length * arr[0].Length)
            {
                arr[i][j] = val;
                if (i <= j + 1 && i + j < size - 1)
                    ++j;
                else if (i < j && i + j >= size - 1)
                    ++i;
                else if (i >= j && i + j > size - 1)
                    --j;
                else 
                    --i;
                ++val;
            }
            
            arr.DisplayArray();
        }
    }
}