using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _110BalancedBinaryTree
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
            TreeNode root1 = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };

            TreeNode root2 = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3)
                    {
                        left = new TreeNode(4),
                        right = new TreeNode(4)
                    },
                    right = new TreeNode(3)
                },
                right = new TreeNode(2)
            };

            Console.WriteLine(IsBalanced(root1));
            Console.WriteLine(IsBalanced(root2));
        }

        private static bool IsBalanced(TreeNode root)
        {
            return MaxDepth(root) != -1;
        }

        private static int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = MaxDepth(root.left);

            if (left == -1)
                return -1;

            int right = MaxDepth(root.right);

            if (right == -1)
                return -1;

            if (Math.Abs(left - right) > 1)
                return -1;

            return 1 + Math.Max(left, right);
        }
    }
}
