using System;
namespace LinkedList.SinglyLinkedList.RemoveNthNodeFromEndOfList
{
    public class Solution
    {
        public Solution()
        {
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode slow = head;
            ListNode fast = head;

            // 讓 fast 先走 n-1 步
            int count = 0;
            while (count < n)
            {
                fast = fast.next;
                count += 1;
            }

            // fast 跟 slow 一起走
            // 讓 slow 走到要移除的 Node 的前一個 Node
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            // 若 fast = null，代表要移除第一個 Node
            // 直接 return slow.next
            if (fast == null)
            {
                return slow.next;
            }
            else
            {
                slow.next = slow.next.next;
            }

            return head;
        }
    }
}
