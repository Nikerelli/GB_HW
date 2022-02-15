using System;

namespace Howework
{
    public static class HW4
    {
        public static void Task26(int a, int b)
        {
            unchecked
            {
                for(int i = 0; i < b; i++)
                {
                    a *= a;
                }
            }

            Console.WriteLine($"a = {a}");
        }

        public static void Task28(int a)
        {
            int val = Math.Abs(a);
            int sum = 0;
            while(val > 0)
            {
                sum += val % 10;
                val = val / 10;
            }

            Console.WriteLine($"Digi sum of value {a} is {sum}");
        }

        public static void Task30()
        {
            var topEdge = Math.Cbrt(int.MaxValue);

            for(int i = 0; i < topEdge; i++)
            {
                var cube = i * i * i;
                if(cube % 2 == 0)
                {
                    Console.WriteLine(cube);
                }
            }
        }

        public static void Task32()
        {
            var rd = new Random();
            var arr = new int[8];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(0, 2);
            }
            Console.WriteLine($"[{string.Join(',', arr)}]");
        }
    }
}
