using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _171ExcelSheetColumnNumber
    {
        public int TitleToNumber(string columnTitle)
        {
            int res = 0;

            foreach (char c in columnTitle)
            {
                int current = c - 'A' + 1;
                res = res * 26 + current;
            }

            return res;
        }
    }
}
