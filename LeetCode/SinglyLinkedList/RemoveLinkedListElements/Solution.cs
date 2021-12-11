using System;
namespace LinkedList.SinglyLinkedList.RemoveLinkedListElements
{
    public class Solution
    {
        public Solution()
        {
        }

        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return head;
            }

            // 在 head 前加一個虛擬的 Node
            ListNode virtualNode = new ListNode(0, head);

            ListNode curr = virtualNode;
            while (curr != null && curr.next != null)
            {
                // 若該 Node 的值等於 val，則移除
                while (curr != null && curr.next != null && curr.next.val == val)
                {
                    curr.next = curr.next.next;
                }

                curr = curr.next;
            }

            head = virtualNode.next;

            return head;
        }
    }
}
