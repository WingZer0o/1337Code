using _1337Code.Add_Two_Numbers;

ListNode l1 = new ListNode(1);
ListNode l2 = new ListNode(1, new ListNode(9, new ListNode(9)));

ListNode result = Solution.AddTwoNumbers(l1, l2);
Console.ReadLine();