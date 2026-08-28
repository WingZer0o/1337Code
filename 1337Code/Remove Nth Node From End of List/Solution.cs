using System;
using System.Collections.Generic;
using System.Text;

namespace _1337Code.Remove_Nth_Node_From_End_of_List
{
    public class Solution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0, head);
            int length = GetLength(head);
            ListNode tmp = dummy;
            int count = 0;
            while (tmp != null)
            {
                count++;
                if (count == length - n + 1)
                {
                    tmp.next = tmp.next.next;
                    break;
                }
                tmp = tmp.next;
            }
            return dummy.next;
        }

        private int GetLength(ListNode head)
        {
            int length = 0;
            while (head != null)
            {
                length++;
                head = head.next;
            }
            return length;
        }
    }
}
