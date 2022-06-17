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
            vals = new Queue<int?>(arr);
            TreeNode root = AddNode(vals.Dequeue());
            var tree = CreateTree(root);
            //var tree = new TreeNode(1);
            //tree.left = null;
            //tree.right = new TreeNode(2);
            //tree.right.left = new TreeNode(3);
            var res = ZigzagTraversal(tree);
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


        public List<List<int>> zigzagRes;

        List<List<int>> ZigzagTraversal(TreeNode tree)
        {

            zigzagRes = new List<List<int>>();
            zigzagRes.Add(new List<int> { tree.val });



            return zigzagRes;

        }

        int TraverseZigzag(TreeNode tree)
        {
            if (tree.left == null) return tree.val;

            int l = TraverseZigzag(tree.left);
            int r = TraverseZigzag(tree.right);

            zigzagRes.Add(new List<int> {  l,r });

            return tree.val;
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
    }
    
}
