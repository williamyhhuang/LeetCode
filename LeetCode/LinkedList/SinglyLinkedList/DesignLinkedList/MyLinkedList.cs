using System;
namespace LinkedList.SinglyLinkedList.DesignLinkedList
{
    public class MyLinkedList
    {
        /// <summary>
        /// Linked List 總長度
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// head
        /// </summary>
        public ListNode head = null;

        /// <summary>
        /// MyLinkedList
        /// </summary>
        public MyLinkedList()
        {
            this.Count = 0;
        }

        /// <summary>
        /// 取得特定位置 Node 的值
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int Get(int index)
        {
            // 若 index 超出範圍，則回傳 -1
            if (index > this.Count - 1 || index < 0)
            {
                return -1;
            }

            ListNode curr = this.head;

            for (var i = 0; i < index; i++)
            {
                curr = curr.next;
            }

            return curr.val;
        }

        /// <summary>
        /// 將 Node 加在起始點
        /// </summary>
        /// <param name="val"></param>
        public void AddAtHead(int val)
        {
            if (head == null)
            {
                head = new ListNode(val);
            }
            else
            {
                ListNode newNode = new ListNode
                {
                    val = val,
                    next = head
                };

                head = newNode;
            }

            Count += 1;
        }

        /// <summary>
        /// 將 Node 加在末端
        /// </summary>
        /// <param name="val"></param>
        public void AddAtTail(int val)
        {
            // 若該 Linked List 為 Null，則加在末端跟加在起始是一樣的
            if (head == null)
            {
                this.AddAtHead(val);
            }
            else
            {
                ListNode newNode = new ListNode(val);

                ListNode curr = head;
                // 先找到最後一個
                while (curr.next != null)
                {
                    curr = curr.next;
                }

                curr.next = newNode;

                Count += 1;
            }
        }

        /// <summary>
        /// 在特定位置加上 Node
        /// </summary>
        /// <param name="index"></param>
        /// <param name="val"></param>
        public void AddAtIndex(int index, int val)
        {
            if (index > this.Count)
            {
                return;
            }

            if (index == 0 || head == null)
            {
                this.AddAtHead(val);
            }
            else
            {
                ListNode newNode = new ListNode();
                newNode.val = val;

                ListNode curr = this.head;
                for (var i = 0; i < index - 1; i++)
                {
                    curr = curr.next;
                }

                ListNode previous = curr;
                newNode.next = previous.next;
                previous.next = newNode;

                this.Count += 1;
            }
        }

        /// <summary>
        /// 移除特定位置的 Node
        /// </summary>
        /// <param name="index"></param>
        public void DeleteAtIndex(int index)
        {
            // 若 index 超出 Linked List 長度，則直接返回
            if (index >= this.Count)
            {
                return;
            }

            // 若 index = 0，代表移除第一個 Node
            if (index == 0)
            {
                this.head = this.head.next;

                this.Count -= 1;
            }
            else
            {
                ListNode curr = this.head;

                // 找到要移除的 Node 的前一個 Node
                for (var i = 0; i < index - 1; i++)
                {
                    curr = curr.next;
                }

                ListNode previous = curr;
                ListNode now = curr.next;
                ListNode next = now.next;

                previous.next = next;

                this.Count -= 1;
            }
        }
    }
}
