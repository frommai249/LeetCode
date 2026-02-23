using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _144BinaryTreePreorderTraversal
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

        public static void Display()
        {

        }

        private static IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();

            Traverse(root, list);

            return list;
        }

        private static void Traverse(TreeNode root, List<int> list)
        {
            if (root == null)
                return;

            list.Add(root.val);
            Traverse(root.left, list);
            Traverse(root.right, list);
        }
    }
}
