using System.Collections.Generic;
using System.Linq;

namespace N_ary_Tree_Preorder_Traversal
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node()
        {
        }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            // Input: root = [1,null,3,2,4,null,5,6]
            // Output: [1,3,5,6,2,4]
        }

        public static IList<int> Preorder(Node root)
        {
            var list = new List<Node>();
            TraverseNodes(ref list, root);
            return list.Select(x => x.val).ToList();
        }

        public static void TraverseNodes(ref List<Node> list, Node node)
        {
            if (node == null)
            {
                return;
            }
            list.Add(node);
            foreach (var childrenNode in node.children)
            {
                TraverseNodes(ref list , childrenNode);
            }
        }
    }
}