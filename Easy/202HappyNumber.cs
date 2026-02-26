using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _202HappyNumber
    {
        public bool IsHappy(int n)
        {
            int slow = n;
            int fast = GetNext(n);

            while(fast != 1 && slow != fast)
            {
                slow = GetNext(slow);
                fast = GetNext(GetNext(fast));
            }

            return fast == 1;
        }

        private int GetNext(int n)
        {
            int sum = 0;
            
            while(n > 0)
            {
                int t = n % 10;
                sum += t * t;
                n /= 10;
            }

            return sum;
        }
    }
}
