using System;
using System.Collections.Generic;
using System.Linq;

namespace Merge_two_sorted_list_nodes
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
            var list1 = new ListNode();
            list1 = null;
            // var list2 = new ListNode();
            var list2 = new ListNode(0);
            list2 = null;
            var result = MergeTwoLists(list1, list2);
            Console.WriteLine();
        }
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            
            var listOne = new List<int>();
            var listTwo = new List<int>();

            AddToList(list1,ref listOne);
            AddToList(list2,ref listTwo);
            if(listOne.Count == 0 && listTwo.Count == 0 )
            {
                var res = new ListNode();
                res = null;
                return res;
            }
            if (list1 == null && list2 == null)
            {
                var res = new ListNode();
                res = null;
                return res;
            }
            var temp = listOne.Concat(listTwo).OrderBy(x => x).ToList();
            var result = new ListNode(temp[0]);
            temp.RemoveAt(0);
            CreateNode(ref temp,ref result);
            
            return result;
        }

        public static void AddToList(ListNode node, ref List<int> list)
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
                AddToList(node.next, ref list);
            }
        }

        public static void CreateNode(ref List<int> list, ref ListNode node)
        {
            if (list.Count != 0)
            {
                node.next = new ListNode(list[0]);
                list.RemoveAt(0);
                CreateNode(ref list, ref node.next);
            }
        }
    }
}