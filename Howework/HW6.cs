using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Howework
{
    public static class HW6
    {
        private const string ExitCommand = "z";
        private static readonly Regex VerticesRegexp = new Regex(@"(\(\d,\d\) ?)+", RegexOptions.Compiled);

        public static void Task42()
        {
            var aboveZeroCount = 0;
            Console.WriteLine($"Enter only integer values in [{int.MinValue},{int.MaxValue}] in other cases algorithm might work in unexpected way.");
            Console.WriteLine($"To exit write '{ExitCommand}'.");
            while (true)
            {
                var input = Console.ReadLine().Trim();
                unchecked
                {
                    if (int.TryParse(input, out int number))
                    {
                        aboveZeroCount += number > 0 
                            ? 1
                            : 0;
                    }
                    else
                    {
                        if (input.Equals(ExitCommand))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That was non integer number, try again.");
                        }
                    }
                }
            }

            Console.WriteLine($"Total positive values entered: {aboveZeroCount}");
        }

        public static void Task44(float k1, float b1, float k2, float b2)
        {
            var x = (b2 - b1) / (k1 - k2);
            Console.WriteLine($"Function y = k1 * x + b1 and y = k2 * x + b2 converge at [{x},{k1 * x + b1}]");
        }

        public static void Task46()
        {
            Console.WriteLine("Enter subsequence of 2d points");
            
            var input = Console.ReadLine();
            var vertices = new List<Vector2>();
            if (VerticesRegexp.IsMatch(input))
            {
                vertices = input.Split(' ')
                    .Select(x =>
                    {
                        var values = x.TrimStart('(').TrimEnd(')').Split(',');
                        return new Vector2(float.Parse(values[0]), float.Parse(values[1]));
                    })
                    .ToList();
            }
            else
            {
                Console.WriteLine("Unexpected format of input vertices.[string as \"(x1,y1) (x2,y2)...\"");
                return;
            }

            Console.WriteLine("Enter an scale coef");
            if(float.TryParse(Console.ReadLine(), out float coef))
            {
                foreach (var vertex in vertices)
                {
                    var scaledVertex = coef * vertex;
                    Console.Write($"({scaledVertex.X};{scaledVertex.Y}) ");
                }
            }
            else
            {
                Console.WriteLine("Unexpected format of scale coef [float].");
            }
            
        }
    }
}
