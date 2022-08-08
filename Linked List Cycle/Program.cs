using System;
using System.Collections.Generic;
using System.Linq;

namespace Linked_List_Cycle
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var node1 = new ListNode(2);
            var node2 = new ListNode(0);
            var node3 = new ListNode(4);
            var node0 = new ListNode(3);
            node0.next = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node1;
            var res = DetectCycle(node0);
            Console.WriteLine(res.val);

        }
        public static ListNode DetectCycle(ListNode head)
        {
            var nodeList = new List<ListNode>();
            AddNodesToStack(ref nodeList, head);

            return nodeList.Last();
        }

        private static void AddNodesToStack(ref List<ListNode> nodeList, ListNode node)
        {
            
            nodeList.Add(node);
            if (nodeList.Contains(node.next.next))
            {
                return;
            }
            if (node.next != null)
            {
                AddNodesToStack(ref nodeList, node.next);
            }
        }
    }
}