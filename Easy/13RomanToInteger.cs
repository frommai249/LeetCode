using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _13RomanToInteger
    {
        public static void Display()
        {
            Console.WriteLine(RomanToInt("III"));
            Console.WriteLine(RomanToInt("LVIII"));
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }

        private static int RomanToInt(string s)
        {
            int res = 0;

            Dictionary<char, int> dic = new Dictionary<char, int>();

            dic['I'] = 1;
            dic['V'] = 5;
            dic['X'] = 10;
            dic['L'] = 50;
            dic['C'] = 100;
            dic['D'] = 500;
            dic['M'] = 1000;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (i - 1 >= 0 && dic[s[i]] > dic[s[i - 1]])
                {
                    res += dic[s[i]] - dic[s[i - 1]];
                    i--;
                }
                else
                {
                    res += dic[s[i]];
                }
            }

            return res;
        }
    }
}
