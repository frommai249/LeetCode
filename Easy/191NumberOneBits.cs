using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _191NumberOneBits
    {
        public int HammingWeight(int n)
        {
            int res = 0;

            while (n != 0)
            {
                if ((n & 1) == 1)
                    res++;

                n >>= 1;
            }

            return res;
        }
    }
}
