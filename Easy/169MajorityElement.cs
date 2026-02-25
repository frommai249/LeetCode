using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _169MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (int i in nums)
            {
                if (dic.ContainsKey(i))
                    dic[i]++;
                else
                    dic.Add(i, 1);
            }

            int max = 0;
            int res = 0;

            foreach (var item in dic)
            {
                 if (max < item.Value)
                {
                    max = item.Value;
                    res = item.Key;
                }
            }



            return res;
        }
    }
}
