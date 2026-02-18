using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _69SqrtX
    {
        public static void Display()
        {
            Console.WriteLine(MySqrt(4));
            Console.WriteLine(MySqrt(8));
        }

        private static int MySqrt(int x)
        {
            if (x < 2)
                return x;

            int l = 1;
            int r = x / 2;
            int m = 0, n = 0;

            while (l <= r)
            {
                m = l + (r - l) / 2;

                if (m == x / m)
                    return m;
                else if (m < x / m)
                {
                    n = m;
                    l = m + 1;
                }
                else
                    r = m - 1;
            }

            return n;
        }
    }
}
