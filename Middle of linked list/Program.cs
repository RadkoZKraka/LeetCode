using System;
using System.Collections.Generic;
using System.Linq;

namespace Middle_of_linked_list
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5,new ListNode(6))))));
            var cos = MiddleNode(list);
            Console.WriteLine();
        }

        public static ListNode MiddleNode(ListNode head)
        {
            var queue = new Queue<ListNode>();
            AddToQueue(head, ref queue);
            if (queue.Count % 2 != 0)
            {
                return queue.Where((x, i) => i == queue.Count / 2 ).FirstOrDefault();
            }

            return queue.Where((x, i) => i == queue.Count / 2).FirstOrDefault();
        }

        public static void AddToQueue(ListNode head,ref Queue<ListNode> queue)
        {
            queue.Enqueue(head);
            if (head.next == null)
            {
                return;
            }
            AddToQueue(head.next,ref queue);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}