using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _136SingleNumber
    {
        public static void Display()
        {
            Console.WriteLine(new int[]{2, 2, 1});
            Console.WriteLine(new int[]{4, 1, 2, 1, 2});
            Console.WriteLine(new int[]{1});
        }

        private static int SingleNumber(int[] nums)
        {
            int res = 0;

            foreach (int num in nums)
                res ^= num;

            return res;
        }

        private static int SingleNumberUseDictionary(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (!dic.ContainsKey(num))
                    dic.Add(num, 0);
                else
                    dic[num] = 1;
            }

            return dic.FirstOrDefault(x => x.Value == 0).Key;
        }

        private static int SingleNumberUseHashSet(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                if (!set.Contains(num))
                    set.Add(num);
                else
                    set.Remove(num);
            }

            return set.FirstOrDefault();
        }
    }
}
