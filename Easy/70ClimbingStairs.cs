using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _70ClimbingStairs
    {
        public static void Display()
        {
            Console.WriteLine(ClimbStairs(2));
            Console.WriteLine(ClimbStairs(3));
            Console.WriteLine(ClimbStairs(4));
            Console.WriteLine(ClimbStairs(5));
            Console.WriteLine(ClimbStairs(6));
        }

        private static int ClimbStairs(int n)
        {
            if (n <= 3)
                return n;

            int f1 = 3, f2 = 2, res = 0;

            for (int i = 4; i <= n; i++)
            {
                res = f1 + f2;
                f2 = f1;
                f1 = res;
            }

            return res;
        }
    }
}
