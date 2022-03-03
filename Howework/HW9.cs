using System;

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
    }
}