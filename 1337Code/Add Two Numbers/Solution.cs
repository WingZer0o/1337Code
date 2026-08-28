using System.Numerics;
using System.Text;

namespace _1337Code.Add_Two_Numbers
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


    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            BigInteger num1 = GetNumberFromLinkedList(l1);
            BigInteger num2 = GetNumberFromLinkedList(l2);
             string sum = (num1 + num2).ToString();

             ListNode dummyHead = new ListNode(0);
             ListNode current = dummyHead;
             for (int i = sum.Length - 1; i >= 0; i--)
             {
                 current.next = new ListNode(int.Parse(sum[i].ToString()));
                 current = current.next;
             }
             return dummyHead.next;
        }

        private BigInteger GetNumberFromLinkedList(ListNode listNode)
        {
            List<int> digits = new();
            digits.Add(listNode.val);
            listNode = listNode.next;
            while (listNode != null)
            {
                digits.Add(listNode.val);
                listNode = listNode.next;
            }
            digits.Reverse();
            StringBuilder sb = new StringBuilder();
            foreach (int digit in digits)
            {
                sb.Append(digit.ToString());
            }
            return BigInteger.Parse(sb.ToString());
        }
    }
}
