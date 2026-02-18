using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _58LengthLastWord
    {
        public static void Display()
        {
            Console.WriteLine(LengthOfLastWord("Hello World"));
            Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
            Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));
        }

        private static int LengthOfLastWord(string s)
        {
            string? lastWord = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
            return lastWord != null ? lastWord.Length : 0;
        }
    }
}
