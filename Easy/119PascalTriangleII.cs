using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _119PascalTriangleII
    {
        public static void Display()
        {
            IList<int> list1 = GetRow(3);
            IList<int> list2 = GetRow(0);
            IList<int> list3 = GetRow(1);

            foreach (var item in list1)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            foreach (var item in list2)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            foreach (var item in list3)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        private static IList<int> GetRow(int rowIndex)
        {
            int[] row = new int[rowIndex + 1];
            row[0] = 1;

            for (int i = 1; i <= rowIndex; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if(j == i)
                        row[j] = 1;
                    else
                        row[j] = row[j] + row[j - 1];
                }
            }

            return row.ToList();
        }
    }
}
