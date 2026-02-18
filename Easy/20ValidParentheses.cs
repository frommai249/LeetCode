using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _20ValidParentheses
    {
        public static void Display()
        {
            Console.WriteLine(IsVallid("()"));
            Console.WriteLine(IsVallid("()[]{}"));
            Console.WriteLine(IsVallid("(]"));
            Console.WriteLine(IsVallid("([])"));
            Console.WriteLine(IsVallid("([)]"));
        }

        private static bool IsVallid(string s)
        {
            if (s.Length <= 1)
                return false;

            char c;
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{' || s[i] == '(' || s[i] == '[')
                {
                    stack.Push(s[i]);
                    continue;
                }
                else
                {
                    if (stack.Count == 0)
                        return false;

                    c = stack.Pop();
                    if (c == '[' && s[i] != ']')
                        return false;
                    else if (c == '{' && s[i] != '}')
                        return false;
                    else if (c == '(' && s[i] != ')')
                        return false;
                }
            }

            if (stack.Count > 0)
                return false;
            return true;
        }
    }
}
