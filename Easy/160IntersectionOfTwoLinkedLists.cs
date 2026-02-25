using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _160IntersectionOfTwoLinkedLists
    {
        class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
            }
        }

        public static void Display()
        {

        }

        private ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;

            ListNode a = headA;
            ListNode b = headB;

            while (a != b)
            {
                a = (a == null) ? headB : a.next;
                b = (b == null) ? headA : b.next;
            }

            return b;
        }
    }
}
