using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.LeetCode.B
{
    internal class Trees2
    {
        Queue<int?> vals;
        public void MyMain()
        {
            int?[] arr = new int?[] { 3, 9, 20, null, null, 15, 7 };
            //int?[] arr = new int?[] { 3, 9, 20, 15, 7, 11 };
            //int?[] arr = new int?[] { 1,2,3,null,4 };
            vals = new Queue<int?>(arr);
            TreeNode root = AddNode(vals.Dequeue());
            var tree = CreateTree(root);


            var res = TraverseZigzagFast(tree);
        }



        List<IList<int>> TraverseZigzagFast(TreeNode tree){
            var list2d = new List<IList<int>>();
            var list = new List<int>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(tree);
            var depth = 0;
            while (queue.Any())
            {
                int count = queue.Count,
                    i = 0;
                list = new List<int>();

                while (i < count)
                {
                    var curr = queue.Dequeue();

                    if (depth % 2 == 0) list.Add(curr.val);
                    else list.Insert(0, curr.val);

                    if (curr.left is not null) queue.Enqueue(curr.left);
                    if (curr.right is not null) queue.Enqueue(curr.right);

                    i++;
                }
                list2d.Add(list);
                depth++;
            }

            return list2d;
        }

        List<IList<int>> TraverseBFS(TreeNode tree)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(tree);
            var list2d = new List<IList<int>>();
            var list = new List<int>();

            var stack = new Stack<TreeNode>();
            bool isFromLeft = false;
            while (queue.Any())
            {
                list = new List<int>();
                while (queue.Any()) {
                    var curr = queue.Dequeue();
                    list.Add(curr.val);
                    stack.Push(curr);
                }
                list2d.Add(list);

                while (stack.Any())
                {
                    var el = stack.Pop();

                    if (isFromLeft)
                    {
                        if(el.left != null)  queue.Enqueue(el.left);
                        if(el.right != null) queue.Enqueue(el.right);
                    }
                    else
                    {
                        if (el.right != null) queue.Enqueue(el.right);
                        if(el.left != null) queue.Enqueue(el.left);
                    }
                }

                isFromLeft = !isFromLeft;
            }

            return list2d;
        }

        int FindTreeDepth(TreeNode tree)
        {
            if (tree == null) return 0;

            int l = FindTreeDepth(tree.left);
            int r = FindTreeDepth(tree.right);//from 1,

            if (l > r) return l + 1;
            else return r + 1;

        }

        public List<int> InorderTraversal(TreeNode root)//[1,null,2,3]
        {
            var stack = new Stack<TreeNode>();
            var list = new List<int>();
            var curr = root;
            
            while (curr != null || stack.Count != 0)
            {

                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }

                curr = stack.Pop();
                list.Add(curr.val);
                curr = curr.right;
                //stack.Push(curr);
            }

            return list;

        }

        TreeNode CreateTree(TreeNode root)
        {
            if (!vals.Any() || root == null) return root;

            if (vals.TryDequeue(out int? res))
            {
                root.left = AddNode(res);
            }

            if (vals.TryDequeue(out int? res2))
            {
                root.right = AddNode(res2);
            }

            CreateTree(root.left);
            CreateTree(root.right);

            return root;
        }
        private TreeNode AddNode(int? val)
        {
            if (val != null)
            {
                return new TreeNode((int)val);
            }
            else
            {
                return null;
            }
        }
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

    }
}
