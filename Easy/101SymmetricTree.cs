using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _101SymmetricTree
    {
        class TreeNode
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
            TreeNode root1 = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2, new TreeNode(4), new TreeNode(3)));
            TreeNode root2 = new TreeNode(1, new TreeNode(2, null, new TreeNode(3)), new TreeNode(2, null, new TreeNode(3)));

            Console.WriteLine(IsSymmetric(root1));
            Console.WriteLine(IsSymmetric(root2));
        }

        private static bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return false;
            return IsMirror(root.left, root.right);
        }

        private static bool IsMirror(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
                return true;

            if (left == null || right == null)
                return false;

            if (left.val != right.val)
                return false;

            return IsMirror(left.left, right.right) && IsMirror(left.right, right.left);
        }
    }
}
