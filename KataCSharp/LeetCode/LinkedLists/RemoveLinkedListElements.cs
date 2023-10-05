using System;
using KataCSharp.Recursion;
using KataCSharp.Common;

namespace KataCSharp.LeetCode.LinkedLists
{
    public class RemoveLinkedListElements
    {
        //ListNode myNode = new ListNode();
        //ListNode linkedList = new ListNode();
        public void Start()
        {
            int[] arr = new int[] { 6, 6, 1 };
            //int[] arr = new int[] { 6,6,6,6 };
            //int[] arr = new int[] { 1, 2, 6, 3, 4, 5, 6 };
            ListNode linkedList = ListNode.LinkedListFromArray(arr);
            int val = 6;
           if(MyRemoveElements(linkedList, val))
            {
            CommonMethods.PrintLinkedList(linkedList);
            }
            else
            {
                Console.WriteLine();
            }
        }

        bool MyRemoveElements(ListNode node, int val)
        {
            if (node == null)
            {
                return true;
            }

            if (node.val == val)
            {
                var nextNode = GetNextNode(node.next, val);
                if(nextNode == null)
                {
                  //  linkedList = null;
                    return false;
                }
                node.val = nextNode.val;
                node.next = nextNode.next;
            }

            if(node.next != null && node.next.val == val)
            {
                node.next = GetNextNode(node.next, val);
            }

           return MyRemoveElements(node.next, val);
        }

        ListNode GetNextNode(ListNode node, int val)
        {
            if (node == null)
            {
                return null;
            }

            if (node.val == val)
               return GetNextNode(node.next, val);

            return node;
        }
    }
}

