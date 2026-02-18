using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _28FindTheIndexFirstOccurrenceString
    {
        public static void Display()
        {
            string haystack1 = "sadbutsad", needle1 = "sad";
            string haystack2 = "leetcode", needle2 = "leeto";
            string haystack3 = "hello", needle3 = "ll";

            Console.WriteLine(StrStr(haystack1, needle1));
            Console.WriteLine(StrStr(haystack2, needle2));
            Console.WriteLine(StrStr(haystack3, needle3));
        }

        private static int StrStr(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                int i = 0;

                while (haystack.Length > needle.Length && haystack.Substring(0, needle.Length) != needle)
                {
                    haystack = haystack.Substring(1, haystack.Length - 1);
                    i++;
                }

                return i;
            }

            return -1;
        }
    }
}
