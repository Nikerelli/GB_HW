using System;

namespace Howework
{
    public static class HW2
    {
        // Task10
        public static void DisplaySecondDigit(int val)
        {
            if(val > 999 || val < 100)
            {
                Console.WriteLine("Value should have 3 digits only\n");
                return;
            }

            Console.WriteLine($"Value: {val}\n2nd digit: {val / 10 % 10}\n");
        }

        // Task12
        public static void RemoveSecondDigit(int val)
        {
            if (val > 999 || val < 100)
            {
                Console.WriteLine("Value should have 3 digits only\n");
                return;
            }

            Console.WriteLine($"Value: {val}\nDeleted 2nd digit: {val % 10 + val / 100 * 10}\n");
        }

        // Task12
        public static void FindThirdDigit(int val)
        {
            if (val < 100)
            {
                Console.WriteLine($"Value: {val}\n3d digit does not exist\n");
                return;
            }

            Console.WriteLine($"Value: {val}\n3d digit: {val / 100 % 10}\n");
        }

        public static void DisplayDayOfWeek(int dayOfWeek)
        {
            if(dayOfWeek < 0 || dayOfWeek > 6)
            {
                Console.WriteLine($"Incorrect input: {dayOfWeek}. It should be in [0,6]\n");
                return;
            }
            var displayPhrase = dayOfWeek == 0 || dayOfWeek == 6
                ? $"It's weekend day! ({(DayOfWeek)dayOfWeek})\n"
                : $"It's not weekend day! ({(DayOfWeek)dayOfWeek})\n";

            Console.WriteLine(displayPhrase);
        }
    }
}
