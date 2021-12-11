using System;
namespace LinkedList.SinglyLinkedList.IntersectionOfTwoLinkedLists
{
    public class Solution
    {
        public Solution()
        {
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int lenA = this.GetCount(headA);
            int lenB = this.GetCount(headB);
            int diff;

            // 讓 headA、headB 的起點切齊
            if (lenA > lenB)
            {
                diff = lenA - lenB;
                headA = this.Move(headA, diff);
            }
            else
            {
                diff = lenB - lenA;
                headB = this.Move(headB, diff);
            }

            // 起點切齊後，就可以找交會點
            while (headA != null && headB != null)
            {
                if (headA == headB)
                {
                    return headA;
                }

                headA = headA.next;
                headB = headB.next;
            }

            return null;
        }

        public int GetCount(ListNode head)
        {
            ListNode temp = head;
            int count = 0;

            while (temp != null)
            {
                count += 1;
                temp = temp.next;
            }

            return count;
        }

        public ListNode Move(ListNode node, int moveCount)
        {
            while (moveCount > 0 & node != null)
            {
                node = node.next;

                moveCount -= 1;
            }

            return node;
        }
    }
}
