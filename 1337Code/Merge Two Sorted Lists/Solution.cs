using System;
using System.Collections.Generic;
using System.Text;

namespace _1337Code.Merge_Two_Sorted_Lists
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
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            List<int> mergedValues = new();
            ListNode temp = list1;
            while (temp != null)
            {
                mergedValues.Add(temp.val);
                temp = temp.next;
            }
            temp = list2;
            while (temp != null)
            {
                mergedValues.Add(temp.val);
                temp = temp.next;
            }
            mergedValues.Sort();
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;
            foreach (int val in mergedValues)
            {
                current.next = new ListNode(val);
                current = current.next;
            }
            return dummy.next;
        }
    }
}
