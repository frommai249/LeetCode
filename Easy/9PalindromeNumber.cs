using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _9PalindromeNumber
    {
        public static void Display()
        {
            Console.WriteLine(IsPalindrome(123));
            Console.WriteLine(IsPalindrome(121));
            Console.WriteLine(IsPalindrome(-121));
        }

        private static bool IsPalindrome(int x)
        {
            int res = 0;
            int temp = x;

            while (temp > 0)
            {
                res = (res * 10) + (temp % 10);
                temp /= 10;
            }

            return x == res;
        }
    }
}
