using System;

namespace Howework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n{nameof(HW8.Task57)}");
            int[][] arr = new int[8][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[10].FillGeneratedValues();
            }
            HW8.Task57(arr);
            Console.WriteLine($"\n{nameof(HW8.Task59)}");
            HW8.Task59(arr);   
            Console.WriteLine($"\n{nameof(HW8.Task61)}");
            HW8.Task61();
            Console.WriteLine($"\n{nameof(HW8.Task63)}");
            HW8.Task63();
        }
    }
}
