using System;
namespace LinkedList.SinglyLinkedList.LinkedListCycle
{
    public class LinkedListCycleTwo
    {
        public LinkedListCycleTwo()
        {
        }

        public ListNode DetectCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            ListNode meetNode = null;

            // 利用 two pointer 找到交會點
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    meetNode = slow;
                    break;
                }
            }

            // 若 meetNode 還是 null，代表沒有交會點
            if (meetNode == null)
                return null;

            // 找到交會點後，開始找循環的起點
            slow = head;
            while (slow != meetNode)
            {
                slow = slow.next;
                meetNode = meetNode.next;
            }

            return slow;
        }
    }
}
