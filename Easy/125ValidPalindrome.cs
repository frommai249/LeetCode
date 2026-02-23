using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _125ValidPalindrome
    {
        public static void Display()
        {
            Console.WriteLine("A man, a plan, a canal");
            Console.WriteLine("race a car");
            Console.WriteLine("raceacar");
        }

        private static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            int left = 0;
            int right = s.Length - 1;

            while (left < right) 
            {
                if (!char.IsLetterOrDigit(s[left]))
                    left++;
                else if (!char.IsLetterOrDigit(s[right]))
                        right--;
                else
                {
                    if (char.ToLower(s[left]) != char.ToLower(s[right]))
                        return false;

                    left++;
                    right--;
                }
            }

            return true;
        }
    }
}
