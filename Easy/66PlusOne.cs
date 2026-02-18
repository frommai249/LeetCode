using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _66PlusOne
    {
        public static void Display()
        {
            int[] a1 = PlusOne(new int[] { 1, 2, 3 });
            int[] a2 = PlusOne(new int[] { 4, 3, 2, 1 });
            int[] a3 = PlusOne(new int[] { 9 });
            int[] a4 = PlusOne(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
            int[] a5 = PlusOne(new int[] { 9, 9 });

            ShowResult(a1);
            ShowResult(a2);
            ShowResult(a3);
            ShowResult(a4);
            ShowResult(a5);
        }

        private static int[] PlusOne(int[] digits)
        {
            char[] chars = new char[digits.Length];

            for (int i = 0; i < digits.Length; i++)
            {
                chars[i] = (char)(digits[i] + '0');
            }

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                int n = chars[i] - '0';

                if (n + 1 < 10)
                {
                    chars[i] = (char)(n + 1 + '0');
                    break;
                }
                else
                {
                    chars[i] = '0';

                    if (i == 0)
                    {
                        int[] r = new int[chars.Length + 1];

                        r[0] = 1;

                        return r;
                    }
                }
            }

            int[] arr = new int[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                arr[i] = chars[i] - '0';
            }

            return arr;
        }

        private static void ShowResult(int[] arr)
        {
            foreach (int i in arr)
                Console.WriteLine(i);
            Console.WriteLine("---");
        }
    }
}
