using System;
namespace LinkedList.SinglyLinkedList.ReverseLinkedList
{
    public class Solution
    {
        public Solution()
        {
        }

        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            /*
            iteration 0:
            curr 在 1，Linked List 為 1->2->3

            iteration 1:
            curr 在 1，做完以後變 2->1->3

            iteration 2:
            curr 在 1，做完以後變 3->2->1
             */
            ListNode curr = head;
            while (curr.next != null)
            {
                ListNode tmp = new ListNode(curr.next.val);
                curr.next = curr.next.next;
                tmp.next = head;

                head = tmp;
            }

            return head;
        }
    }
}
