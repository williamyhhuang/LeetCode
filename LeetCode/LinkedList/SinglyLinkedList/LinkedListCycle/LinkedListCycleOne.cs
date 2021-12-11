﻿using System;
namespace LinkedList.SinglyLinkedList.LinkedListCycle
{
    public class LinkedListCycleOne
    {
        public LinkedListCycleOne()
        {
        }

        public bool HasCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (fast == slow)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
