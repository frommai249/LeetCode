using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _112PathSum
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
            int target1 = 22;
            TreeNode root1 = new TreeNode(5,
                                        new TreeNode(4,
                                            new TreeNode(11,
                                                new TreeNode(7),
                                                new TreeNode(2))),
                                        new TreeNode(8,
                                            new TreeNode(13),
                                            new TreeNode(4,
                                                new TreeNode(1))));

            int target2 = 5;
            TreeNode root2 = new TreeNode(1,
                                        new TreeNode(2),
                                        new TreeNode(3));

            int target3 = 0;
            TreeNode? root3 = null;

            int target4 = 1;
            TreeNode root4 = new TreeNode(1);

            int target5 = 1;
            TreeNode root5 = new TreeNode(1, new TreeNode(2));

            Console.WriteLine("Example 1 : " + HasPathSum(root1, target1));
            Console.WriteLine("Example 2 : " + HasPathSum(root2, target2));
            Console.WriteLine("Example 3 : " + HasPathSum(root3, target3));
            Console.WriteLine("Example 3 : " + HasPathSum(root4, target4));
            Console.WriteLine("Example 3 : " + HasPathSum(root5, target5));
        }

        private static bool HasPathSum(TreeNode? root, int targetSum)
        {
            if (root == null)
                return false;

            return Add(root, targetSum, root.val);
        }

        private static bool Add(TreeNode node, int sum, int currSum)
        {
            if (node.left == null && node.right == null)
                return sum == currSum;
            else
            {
                if (node.left != null)
                    if (Add(node.left, sum, currSum + node.left.val))
                        return true;

                if (node.right != null)
                    if (Add(node.right, sum, currSum + node.right.val))
                        return true;
            }

            return false;
        }
    }
}
