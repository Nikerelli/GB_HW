using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howework
{
    public static class HW1
    {
        // Task2
        public static bool IsEven(int val)
        {
            return val % 2 == 0;
        }

        // Task4
        public static int MaxFrom4(int val1, int val2, int val3)
        {
            var arr = new int[] { val1, val2, val3};
            return arr.Max();
        }

        // Task 6
        public static void DisplayCompare(int left, int right)
        {
            Console.WriteLine($"Value {Math.Max(left, right)} more than {Math.Min(left, right)}");
        }

        // Task8
        public static void DisplayEvens(int n)
        {
            if (n < 2)
            {
                return;
            }

            for (int i = 2; i <= n; i += 2)
            {
                Console.Write(i);
            }
        }
    }
}
