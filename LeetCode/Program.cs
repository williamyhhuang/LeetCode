﻿using System;
using LinkedList.SinglyLinkedList.PalinDromeLinkedList;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            //ListNode node3 = new ListNode(2);
            //ListNode node4 = new ListNode(1);

            node1.next = node2;
            //node2.next = node3;
            //node3.next = node4;

            Solution solution = new Solution();

            var result = solution.IsPalindrome(node1);
        }
    }
}
