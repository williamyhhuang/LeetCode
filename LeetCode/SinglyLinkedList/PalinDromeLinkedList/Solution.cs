using System;
namespace LinkedList.SinglyLinkedList.PalinDromeLinkedList
{
    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            // Get Middle Node
            ListNode middleNode = this.GetMiddleNode(head);

            // Reverse
            ListNode reversedNode = this.ReverseLinkedList(middleNode);

            ListNode curr = head;
            while(reversedNode.next != null)
            {
                if(curr.val != reversedNode.val)
                {
                    return false;
                }

                curr = curr.next;
                reversedNode = reversedNode.next;
            }

            return true;
        }

        private ListNode ReverseLinkedList(ListNode node)
        {
            if (node == null || node.next == null)
            {
                return node;
            }

            ListNode curr = node;
            while (curr.next != null)
            {
                ListNode tmp = new ListNode(curr.next.val);
                curr.next = curr.next.next;
                tmp.next = node;

                node = tmp;
            }

            return node;
        }

        private ListNode GetMiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
    }
}
