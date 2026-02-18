using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _14LongestCommonPrefix
    {
        public static void Display()
        {
            Console.WriteLine(LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
            Console.WriteLine(LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
        }

        private static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return string.Empty;

            if (strs.Length == 1)
                return strs[0];

            char c;
            int min = strs[0].Length;

            string res = "";

            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i].Length < min)
                {
                    min = strs[i].Length;
                }
            }

            for (int i = 0; i < min; i++)
            {
                c = strs[0][i];

                for (int j = 0; j < strs.Length; j++)
                {
                    if (c != strs[j][i])
                    {
                        return res;
                    }
                }

                res += c;
            }

            return res;
        }
    }
}
