using System;
using System.Linq;

namespace Howework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n{nameof(HW9.Task64)}");
            HW9.Task64(1,4);
            Console.WriteLine($"\n{nameof(HW9.Task66)}");
            HW9.Task66(1,15);
            Console.WriteLine($"\n{nameof(HW9.Task68)}");
            HW9.Task68(1,5);
            Console.WriteLine($"\n{nameof(HW9.Task72)}");
            var result = HW9.Task72(new int[] { 0, 1, 1, 1, 1, 0, 0, 0, 1 });
            foreach(var val in result)
            {
                Console.WriteLine(val);
            }
        }
    }
}
