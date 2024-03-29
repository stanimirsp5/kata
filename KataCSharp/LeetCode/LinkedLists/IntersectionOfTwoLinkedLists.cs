﻿using System;
namespace KataCSharp.LeetCode.LinkedLists
{
    public class IntersectionOfTwoLinkedLists
    {
        public void Start()
        {
            BuildList();
        }


        void BuildList()
        {
            int[] arr1 = new int[] { 2 };
            //int[] arr1 = new int[] { 1, 9, 1, 2, 4 };
            //int[] arr1 = new int[] { 1 };

            var nodeA = ListNode.LinkedListFromArray(arr1);
            int[] arr2 = new int[] { 1,5 };
            //int[] arr2 = new int[] { 3, 2, 4 };
            //int[] arr2 = new int[] { 1 };

            var nodeB = ListNode.LinkedListFromArray(arr2);

            int[] arr3 = new int[] { 4 };
            //int[] arr3 = new int[] { 2,4 };
            //int[] arr3 = new int[] { 1 };

            var commonList = ListNode.LinkedListFromArray(arr3);
            nodeA.ComposeLists(commonList);
            nodeB.ComposeLists(commonList);

            //var res = FindIntersectedNode(nodeA, nodeB);
            var res = GetIntersectionNode(nodeA, nodeB);
        }

        // algorithm for linked list intersection
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode a = headA,
                     b = headB;

            while (a != b)
            {
                a = a == null ? headB : a.next;
                b = b == null ? headA : b.next;
            }

            return a;
        }

        ListNode FindIntersectedNode(ListNode nodeA, ListNode nodeB)
        {
            int l1Length = GetLinkedListLength(nodeA, 1);
            int l2Length = GetLinkedListLength(nodeB, 1);
            int lengthDifference;
            bool isAorB;
            if (l1Length > l2Length)
            {
                lengthDifference = l1Length - l2Length;
                isAorB = true;
            }
            else
            {
                lengthDifference = l2Length - l1Length;
                isAorB = false;
            }

            var commonNde = FindCommonNodes(nodeA, nodeB, new ListNode(), lengthDifference, isAorB);

            return commonNde;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodeA"></param>
        /// <param name="nodeB"></param>
        /// <param name="nodeC"></param>
        /// <param name="lengthDifference"></param>
        /// <param name="isDifferenceOk"></param>
        /// <param name="isAorB">If true nodeA is longer. If false nodeB is longer</param>
        /// <param name="isForFirstTime"></param>
        /// <returns></returns>
        ListNode FindCommonNodes(ListNode nodeA, ListNode nodeB, ListNode nodeC, int lengthDifference, bool isAorB)
        {
            if (nodeA == null)
            {
                if (nodeC.val == 0)
                {
                    if (nodeA == nodeB) return nodeA;

                    return null;
                }
                return nodeC;
            }

            if (lengthDifference == 0 && nodeA == nodeB)
            {
                if (nodeC.val == 0 && nodeC.next == null)
                {
                    nodeC = nodeA;
                }
            }
            if (lengthDifference != 0)
            {
                lengthDifference -= 1;
                if (isAorB)
                {
                    return FindCommonNodes(nodeA.next, nodeB, nodeC, lengthDifference, isAorB);
                }
                else
                {
                    return FindCommonNodes(nodeA, nodeB.next, nodeC, lengthDifference, isAorB);
                }
            }
            else
            {
                return FindCommonNodes(nodeA.next, nodeB.next, nodeC, lengthDifference, isAorB);
            }
        }

        int GetLinkedListLength(ListNode listNode, int length)
        {
            if (listNode.next == null)
                return length;

            return GetLinkedListLength(listNode.next, length + 1);
        }


    }
}

