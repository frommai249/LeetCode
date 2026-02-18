using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _35SearchInsertPosition
    {
        public static void Display()
        {
            int[] arr = new int[] { 1, 3, 5, 6 };

            Console.WriteLine("res = " + SearchInsert(arr, 5));
            Console.WriteLine();
            Console.WriteLine("res = " + SearchInsert(arr, 2));
            Console.WriteLine();
            Console.WriteLine("res = " + SearchInsert(arr, 7));
            Console.WriteLine();
        }

        private static int SearchInsert(int[] nums, int target)
        {
            int m = 0, l = 0, r = nums.Length - 1;

            while (l <= r)
            {
                m = (l + r) / 2;

                if (nums[m] == target)
                    return m;

                if (nums[m] > target)
                    r = m - 1;
                else
                    l = m + 1;
            }

            return l;
        }
    }
}
