using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class RemoveDuplicatesFromSortedList83
    {
        class ListNode
        {
            public int val;
            public ListNode? next;
            public ListNode(int val = 0, ListNode? next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static void Display()
        {
            ListNode example1 =
                new ListNode(1, new ListNode(1, new ListNode(2)));
            ListNode example2 =
                new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));

            ListNode? ex1 = DeleteDuplicates(example1);
            ListNode? ex2 = DeleteDuplicates(example2);

            while (ex1 != null)
            {
                Console.WriteLine(ex1.val);
                ex1 = ex1.next;
            }

            Console.WriteLine();

            while (ex2 != null)
            {
                Console.WriteLine(ex2.val);
                ex2 = ex2.next;
            }
        }

        private static ListNode? DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return null;

            ListNode r = head;

            while (r != null && r.next != null)
            {
                if (r.val == r.next.val)
                    r.next = r.next.next;
                else
                    r = r.next;
            }

            return head;
        }
    }
}
