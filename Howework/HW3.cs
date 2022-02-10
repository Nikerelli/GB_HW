using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Howework
{
    public static class HW3
    {
        public static void Task18(bool x, bool y)
        {
            Console.WriteLine(!(x && y) == !x && !y);
        }

        public static void Task20(int quarter)
        {
            if(quarter < 1 || quarter > 4)
            {
                Console.WriteLine("Quarter should has number [1;4]");
                return;
            }
            var x = quarter == 1 || quarter == 4
                ? "x restricted by [0; +infinity)"
                : "x restricter by (-infinity; 0]";

            var y = quarter == 1 || quarter == 2
                ? "y restricted by [0; +infinity)"
                : "y restricter by (-infinity; 0]";

            Console.WriteLine($"{x}\n{y}");
        }

        public static void Task22(Vector3 x, Vector3 y)
        {
            Console.WriteLine($"Distance between x [{x.X}, {x.Y}, {x.Z}] and y [{y.X}, {x.Y}, {x.Z}] is {Vector3.Distance(x, y)}");
        }

        public static void Task24(int n)
        {
            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine($"Cub of {i} is {i * i * i}");
            }
        }
    }
}
