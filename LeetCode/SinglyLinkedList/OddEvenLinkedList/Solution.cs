using System;
namespace LinkedList.SinglyLinkedList.OddEvenLinkedList
{
    public class Solution
    {
        public Solution()
        {
        }

        public ListNode OddEvenList(ListNode head)
        {
            int nodeCount = this.GetTotalCount(head);

            // 因是要移除偶數位置的 Node，故只需迭代 (nodeCount / 2) 次 
            int iteration = (nodeCount / 2);

            ListNode curr = head;
            for (int i = 0; i < iteration; i++)
            {
                ListNode tmp = new ListNode(curr.next.val);
                curr.next = curr.next.next;
                head = this.AddAtEnd(head, tmp);

                curr = curr.next;
            }

            return head;
        }

        private ListNode AddAtEnd(ListNode head, ListNode node)
        {
            ListNode curr = head;
            while (curr != null && curr.next != null)
            {
                curr = curr.next;
            }

            curr.next = node;

            return head;
        }

        private int GetTotalCount(ListNode head)
        {
            int count = 0;

            ListNode curr = head;
            while (curr != null)
            {
                count += 1;
                curr = curr.next;
            }

            return count;
        }
    }
}
