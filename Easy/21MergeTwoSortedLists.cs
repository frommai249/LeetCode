using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _21MergeTwoSortedLists
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

            public static void Display()
            {
                ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
                ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

                ListNode list3 = new ListNode();
                ListNode list4 = new ListNode();

                ListNode list5 = new ListNode();
                ListNode list6 = new ListNode(0);

                ShowResult(MergeTwoLists(list1, list2));
                ShowResult(MergeTwoLists(list3, list4));
                ShowResult(MergeTwoLists(list5, list6));
            }

            private static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
            {
                ListNode r = new ListNode();
                ListNode t = r;

                while (list1 != null && list2 != null)
                {
                    if (list1.val <= list2.val)
                    {
                        t.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        t.next = list2;
                        list2 = list2.next;
                    }

                    t = t.next;
                }

                if (list1 != null)
                    t.next = list1;
                else if (list2 != null)
                    t.next = list2;

                return r.next;
            }

            private static void ShowResult(ListNode? t)
            {
                while (t != null)
                {
                    Console.WriteLine(t.val);
                    t = t.next;
                }
            }
        }
    }
}
