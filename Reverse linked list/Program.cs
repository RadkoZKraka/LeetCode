using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_linked_list
{
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
    internal class Program
    {
        public static void Main(string[] args)
        {
            // var list1 = new ListNode(-3,new ListNode(-1,new ListNode(3,new ListNode(4))));
            var list = new ListNode(1,new ListNode(2, new ListNode(-4, new ListNode(5))));
            // list = null;
            // var list2 = new ListNode();
            // var list2 = new ListNode(0);
            // list2 = null;
            var result = ReverseList(list);
            Console.WriteLine();
        }
        public static ListNode ReverseList(ListNode head) 
        {
            var list = new List<int>();
            
            AddNodesToList(head,ref list);
            if(list.Count == 0)
            {
                var res = new ListNode();
                res = null;
                return res;
            }
            if (list == null)
            {
                var res = new ListNode();
                res = null;
                return res;
            }
            list.Reverse();
            var result = new ListNode(list[0]);
            list.RemoveAt(0);
            CreateNodeFromList(ref list,ref result);
            return result;
        }
        public static void AddNodesToList(ListNode node, ref List<int> list)
        {
            if (node == null) return;
            if (list == null)
            {
                list = new List<int>();
            }
            if (node.val == 0 && node.next == null )
            {
                list.Add(0);
                return;                                                                   
            }
            list.Add(node.val);
            if (node.next != null)
            {
                if (node.next.val == 0 && node.next.next == null)
                {
                    list.Add(node.next.val);
                    return;                                                                   
                }
                AddNodesToList(node.next, ref list);
            }
        }
        public static void CreateNodeFromList(ref List<int> list, ref ListNode node)
        {
            if (list.Count != 0)
            {
                node.next = new ListNode(list[0]);
                list.RemoveAt(0);
                CreateNodeFromList(ref list, ref node.next);
            }
        }
    }
}