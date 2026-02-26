using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _190ReverseBit
    {
        public static int ReverseBits(int n)
        {
            int res = 0;

            for(int i = 0; i < 32; i++)
            {
                res <<= 1;
                res |= (n & 1);
                n >>= 1;
            }

            return res;
        }
    }
}
