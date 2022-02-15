using System;
using System.Linq;

namespace Howework
{
    public static class HW5
    {
        public static void Task34()
        {
            Console.WriteLine(nameof(Task34));
            var arr = new int[10].FillGeneratedValues(100, 1000);
            Console.WriteLine($"Source array: {string.Join(' ', arr)}");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * -1;
            }
            Console.WriteLine($"Result array: {string.Join(' ', arr)}\n");
        }
        public static void Task36()
        {
            Console.WriteLine(nameof(Task36));
            var arr = new int[10].FillGeneratedValues(100, 1000);
            var evens = 0;
            var odds = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    evens++;
                }
                else
                {
                    odds++;
                }
            }

            Console.WriteLine($"{string.Join(' ', arr)}\nEvens: {evens}\nOdds: {odds}\n");
        }

        public static void Task38()
        {
            Console.WriteLine(nameof(Task38));
            var arr = new int[10].FillGeneratedValues(0,10);
            var sum = 0;

            for (int i = 1; i < arr.Length; i += 2)
            {
                sum += arr[i];
            }

            Console.WriteLine($"{string.Join(' ', arr)}\nSum: {sum}\n");
        }

        public static void Task40()
        {
            Console.WriteLine(nameof(Task40));
            var arr = new double[10].FillGeneratedValues(0, 10);

            Console.WriteLine($"{string.Join(' ', arr)}\nDiff: {arr.Max() - arr.Min()}\n");
        }
    }
}
