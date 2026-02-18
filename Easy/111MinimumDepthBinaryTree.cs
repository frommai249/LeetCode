using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _111MinimumDepthBInaryTree
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
            TreeNode root1 = new TreeNode()
            {
                val = 3,
                left = new TreeNode()
                {
                    val = 9
                },
                right = new TreeNode()
                {
                    val = 20,
                    left = new TreeNode()
                    {
                        val = 15
                    },
                    right = new TreeNode()
                    {
                        val = 7
                    }
                }
            };

            TreeNode root2 = new TreeNode()
            {
                val = 2,
                right = new TreeNode()
                {
                    val = 3,
                    right = new TreeNode()
                    {
                        val = 4,
                        right = new TreeNode()
                        {
                            val = 5,
                            right = new TreeNode()
                            {
                                val = 6
                            }
                        }
                    }
                }
            };

            Console.WriteLine(MinDepth(root1));
            Console.WriteLine(MinDepth(root2));
        }

        private static int MinDepth(TreeNode root)
        {
            if (root == null) return 0;

            Queue<TreeNode> que = new Queue<TreeNode>();
            que.Enqueue(root);
            int count = 1, depth = 1;

            while (que.Count > 0)
            {
                TreeNode node = que.Dequeue();
                count--;

                if (node.left == null && node.right == null) return depth;

                if (node.left != null)
                {
                    que.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    que.Enqueue(node.right);
                }

                if (count == 0)
                {
                    count = que.Count;
                    depth++;
                }
            }

            return depth;
        }
    }
}
