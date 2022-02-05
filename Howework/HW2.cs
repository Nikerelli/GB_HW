using System;
using System.Collections.Generic;
using System.Linq;

namespace Howework
{
    public static class HW2
    {
        // Task1
        // https://leetcode.com/problems/jump-game-ii/
        public static int Jump(int[] nums)
        {
            int jumps = 0;
            int longest = -1;
            int target = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                longest = Math.Max(nums[i] + i, longest);
                if (i == target)
                {
                    jumps++;
                    target = longest;
                }
            }
            return jumps;
        }

        // Task2
        // https://leetcode.com/problems/powx-n/
        public static double MyPow(double x, int n)
        {
            if (n < 0) return 1 / x * MyPow(1 / x, -(n + 1));
            if (n == 0) return 1;
            if (n == 1) return x;
            if (n % 2 == 0) return MyPow(x * x, n / 2);
            return x * MyPow(x * x, n / 2);
        }

        // Task3
        // https://leetcode.com/problems/divide-two-integers/
        public static int Divide(int dividend, int divisor)
        {
            if (divisor == 0 | (dividend == Int32.MinValue && divisor == -1))
                return Int32.MaxValue;

            bool sign = (dividend > 0) ^ (divisor > 0);
            uint dd = (uint)(dividend < 0 ? -dividend : dividend);
            uint dr = (uint)(divisor < 0 ? -divisor : divisor);
            int reminder = 0;

            for (int i = 31; i >= 0; i--)
            {
                if ((dd >> i) >= dr)
                {
                    reminder = reminder << 1 | 0x01;
                    dd -= dr << i;
                }
                else
                    reminder = reminder << 1;
            }
            return sign ? -reminder : reminder;
        }

        // Task4
        // https://leetcode.com/problems/group-anagrams/
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dic = new Dictionary<string, IList<string>>();
            for(int i = 0; i < strs.Length; i++)
            {
                var wordAsArr = strs[i].ToArray();
                Array.Sort(wordAsArr);
                var word = new string(wordAsArr);

                if (dic.ContainsKey(word))
                {
                    dic[word].Add(strs[i]);
                }
                else
                {
                    dic.Add(word, new List<string> { strs[i] });
                }
            }

            return dic.Select(x => x.Value).ToList();
        }
    }
}
