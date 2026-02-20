using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _118PascalTriagle
    {
        public static void Display()
        {
            IList<IList<int>> test = new List<IList<int>>();

            test.Add(new List<int> { 1 });
        }

        private static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                List<int> row = new List<int>();

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        int left = res[i - 1][j - 1];
                        int right = res[i - 1][j];
                        row.Add(left + right);
                    }
                }

                res.Add(row);
            }

            return res;
        }
    }
}
