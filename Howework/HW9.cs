using System;
using System.Linq;

namespace Howework
{
    public static class HW9
    {
        public static void Task64(int m, int n)
        {
            while (m <= n)
            {
                Console.WriteLine(m++);
            }
        }
        
        public static void Task66(int m, int n)
        {
            var sum = 0;
            while (m <= n)
            {
                sum += m++;
            }
            
            Console.WriteLine($"Sum: {sum}");
        }
        
        public static int Task68(int m, int n, int level = 1)
        {
            Console.WriteLine($"Level #{level}, m = {m}, n = {n}");
            if (m == 0)
            {
                return n + 1;
            }

            if (m > 0 && n == 0)
            {
                return Task68(m - 1, 1, level + 1);
            }

            return Task68(m - 1, Task68(m, n - 1, level + 2), level + 1);
        }

        public static int[] Task72(int[] arr)
        {
            if(arr.Length < 6)
            {
                return new int[] { };
            }

            return new int[]
            {
                ConvertToInt(arr[0..2]),
                ConvertToInt(arr[2..5]),
                ConvertToInt(arr[5..8]),
                ConvertToInt(arr[8..])
            };
        }

        private static int ConvertToInt(int[] arr)
        {
            if(arr.Any(x => x != 0 && x != 1))
            {
                return 0;
            }

            var result = 0;
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                result += (int)Math.Pow(2, arr.Length - i - 1) * arr[i];
            }

            return result;
        }
    }
}