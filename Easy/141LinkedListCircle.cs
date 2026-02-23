using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _141LinkedListCircle
    {
        class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode (int x, ListNode temp)
            {
                val = x;
                next = temp;
            }
        }

        public static void Display()
        {
            Console.WriteLine(HasCycle(new ListNode(3, new ListNode(2, new ListNode(0, new ListNode(-4, null))))));
            Console.WriteLine(HasCycle(new ListNode(1, new ListNode(2, null))));
            Console.WriteLine(HasCycle(new ListNode(1, null)));
        }

        private static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return false;
            else if (head.next == head)
                return true;

            ListNode temp = head;

            while (head != null && temp != null && temp.next != null)
            {
                temp = temp.next.next;
                head = head.next;

                if (head == temp)
                    return true;
            }

            return false;
        }
    }
}
