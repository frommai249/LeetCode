using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _1TwoSum
    {
        public static void Display()
        {
            int[] nums1 = { 2, 7, 11, 15 };
            int[] nums2 = { 3, 2, 4 };
            int[] nums3 = { 3, 3 };

            int[] res = { 0, 0 };

            res = TwoSum(nums1, 9);
            Console.WriteLine(res[0] + "\t" + res[1]);

            res = TwoSum(nums2, 6);
            Console.WriteLine(res[0] + "\t" + res[1]);

            res = TwoSum(nums3, 6);
            Console.WriteLine(res[0] + "\t" + res[1]);
        }

        private static int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2] { 0, 0 };

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        res[0] = i;
                        res[1] = j;
                        return res;
                    }
                }
            }

            return res;
        }

        private static int[] TwoSum1ms(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int temp = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                temp = target - nums[i];

                if (dic.ContainsKey(temp))
                {
                    return new int[] { dic[temp], i };
                }

                if (!dic.ContainsKey(temp))
                {
                    dic[nums[i]] = i;
                }
            }

            return new int[] { -1, -1 };
        }
    }
}
