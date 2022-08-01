// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new ListNode(1, new ListNode(2, new ListNode(1)));
            // Console.WriteLine(new Queue<int>( new []{3,4,5,6}).Equals(new Queue<int>( new []{3,4,5,6})));
            Console.WriteLine(IsPalindrome(list));
        }
    
        static bool IsPalindrome(ListNode head)
        {
        
            var nodeList = new Queue<int>();
            AddToList(ref nodeList, head);
            var reversedNodeList = new Queue<int>(nodeList.Reverse());
        
            return   String.Join("",nodeList.ToArray()) == String.Join("",reversedNodeList.ToArray());
        }

        static void AddToList(ref Queue<int> list, ListNode listNode)
        {
            list.Enqueue(listNode.val);
            if (listNode.next != null)
            {
                AddToList(ref list, listNode.next);

            }
        }
    }
    public class ListNode
    {
        public ListNode next;
        public int val;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    
    
}
