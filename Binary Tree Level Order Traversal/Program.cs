using System;
using System.Collections.Generic;
using System.Linq;

namespace Binary_Tree_Level_Order_Traversal
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            // Input: root = [3,9,20,null,null,15,7]
            // Output: [[3],[9,20],[15,7]]
            var res = LevelOrder(new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15) , new TreeNode(7))));
            Console.WriteLine();
        }

        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            var list = new Dictionary<TreeNode, int>();
            var res = new List<List<int>>();
            var levels = new List<int>();
            
            ByLevelNodes(ref list, 0 , root);
            foreach (var level in list.Values)
            {
                var lev = list.Where(x => x.Value == level).Select(x => x.Key).Select(x => x.val).ToList();
                
                if (!levels.Contains(level))
                {
                    res.Add(lev);
                }
                levels.Add(level);
            }
            return res.ToArray();
        }
        
        public static void ByLevelNodes(ref Dictionary<TreeNode, int>  list , int level, TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            list.Add(node, level);
            level++;
            if (node.left != null)
            {
                ByLevelNodes(ref list, level , node.left);
            }
            if (node.right != null)
            {
                ByLevelNodes(ref list, level , node.right);
            }
        }
    }
}