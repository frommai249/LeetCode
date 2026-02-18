using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _27RemoveElement
    {
        public static void Display()
        {
            int[] nums1 = new int[] { 3, 2, 2, 3 };
            int[] nums2 = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };

            Console.WriteLine(RemoveElement(nums1, 3));
            Console.WriteLine();
            Console.WriteLine(RemoveElement(nums2, 2));
        }

        private static int RemoveElement(int[] nums, int val)
        {
            int res = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[res] = nums[i];
                    res++;
                }
            }

            return res;
        }
    }
}
