using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.LeetCode
{
    internal class Trees
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
        public void MyMain()
        {
            var tree = new TreeNode(8);
            tree.left = new TreeNode(4);
            tree.left.left = new TreeNode(3);
            tree.left.left.left = new TreeNode(1);
            tree.left.right = new TreeNode(5);
            tree.right = new TreeNode(10);
            tree.right.left = new TreeNode(9);
            tree.right.right = new TreeNode(20);
            tree.right.right.right = new TreeNode(25);
            tree.right.right.left = new TreeNode(17);

            //var t = BSTV(tree, null, null);// IsValidBST(tree);
            int[] arr = new int[] { -10,-3,0,5,9 };
            var t = ArrayToTree(arr);
        }

        public TreeNode ArrayToTreeIterative(int[] arr)
        {
            var queue = new Queue<TreeNode>();
            int mid = arr.Length / 2;
            queue.Enqueue(new TreeNode(arr[mid]));
            while (queue.Count != 0)
            {
                var root = queue.Dequeue();
                root.left = new TreeNode(arr[mid]);
                root.right = new TreeNode(arr[mid]);


            }


            return new TreeNode();
        }

        public TreeNode ArrayToTree(int[] arr)
        {

            return ATT(arr,0,arr.Length-1);
        }

        private TreeNode ATT(int[] arr, int start, int end)
        {
            if(start > end) return null;

            int mid = start + (end - start) / 2;
            var tree = new TreeNode(arr[mid]);

            tree.left = ATT(arr,start,mid-1);
            tree.right = ATT(arr,mid+1,end);

            return tree;
        }

        public bool Validate(TreeNode root, int? low, int? high)
        {
            // Empty trees are valid BSTs.
            if (root == null)
            {
                return true;
            }
            // The current node's value must be between low and high.
            if ((low != null && root.val <= low) || (high != null && root.val >= high))
            {
                return false;
            }
            // The left and right subtree must also be valid.
            return Validate(root.right, root.val, high) && Validate(root.left, low, root.val);
        }

        public bool IsValidBST(TreeNode root)
        {
            return Validate(root, null, null);
        }

        private Stack<TreeNode> stack = new Stack<TreeNode>();
        private Stack<int?> upperLimits = new Stack<int?>();
        private Stack<int?> lowerLimits = new Stack<int?>();
        public void Update(TreeNode root, int? low, int? high)
        {
            stack.Push(root);
            lowerLimits.Push(low);
            upperLimits.Push(high);
        }
        public bool IsValidBSTIterative(TreeNode tree)
        {
            int? low = null, high = null, val;
            Update(tree, low, high);

            while (!stack.Any())
            {
                tree = stack.Pop();
                low = lowerLimits.Pop();
                high = upperLimits.Pop();

                if (tree == null) continue;
                val = tree.val;
                if (low != null && val <= low) return false;
                if(high != null && val >= high) return false;

                Update(tree.right, val, high);
                Update(tree.left, low, val);
            }

            return true;
        }


        private Stack<TreeNode> myStack = new Stack<TreeNode>();
        private Stack<int?> roots = new Stack<int?>();
        private Stack<int?> subroots = new Stack<int?>();
        public void Update2(TreeNode node, int? root, int? sub)
        {
            myStack.Push(node);
            roots.Push(root);
            subroots.Push(sub);
        }
        public bool BSTIterate(TreeNode tree)
        {
            myStack.Push(tree);

            while (myStack.Any())
            {
                var node = myStack.Pop();
                var root = roots.Pop();
                var subroot = subroots.Pop();
                if(root != null && node.val <= root)
                {
                    return false;
                }
                if(subroot !=null && node.val >= subroot)
                {
                    return false;
                }

                Update2(node.left, root, node.val);
                Update2(node.right, node.val, subroot);

            }
            return true;
        }
        public bool BSTV(TreeNode tree, int? root, int? subRoot)
        {
            if(tree == null) return true;

            if((root != null && tree.val <= root) || (subRoot != null && tree.val >= subRoot))
            {
                return false;
            }

            return BSTV(tree.right, tree.val, subRoot) && BSTV(tree.left, root, tree.val);

        }
    }
}
