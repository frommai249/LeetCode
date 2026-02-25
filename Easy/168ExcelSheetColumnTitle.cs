using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _168ExcelSheetColumnTitle
    {
        public string ConvertToTitle(int columnNumber)
        {
            string res = string.Empty;

            while (columnNumber > 0)
            {
                columnNumber--;

                int reminder = columnNumber % 26;
                char c = (char)(reminder + 'A');

                res = c + res;

                columnNumber /= 26;
            }

            return res;
        }
    }
}
