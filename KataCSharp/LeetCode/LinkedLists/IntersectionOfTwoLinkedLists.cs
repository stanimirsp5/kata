using System;
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
            int[] arr1 = new int[] { 4, 1 };
            var nodeA = ListNode.LinkedListFromArray(arr1);
            int[] arr2 = new int[] { 5, 6, 1 };
            var nodeB = ListNode.LinkedListFromArray(arr2);

            int[] arr3 = new int[] { 8, 4, 5 };
            var commonList = ListNode.LinkedListFromArray(arr3);
            nodeA.ComposeLists(commonList);
            nodeB.ComposeLists(commonList);

           var res = FindIntersectedNode(nodeA, nodeB);
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
        /// <param name="isAorB">If true nodeA is lengther. If false nodeB is lengther</param>
        /// <param name="isForFirstTime"></param>
        /// <returns></returns>
        ListNode FindCommonNodes(ListNode nodeA, ListNode nodeB, ListNode nodeC, int lengthDifference, bool isAorB)
        {
            if (nodeA.next == null)
            {
                return nodeC;
            }

            if (lengthDifference == 0 && nodeA.next == nodeB.next)
            {
                if (nodeC == null)
                {
                    nodeC = nodeA.next;
                }
                else
                {
                    nodeC.next = nodeA.next;
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
                return FindCommonNodes(nodeA.next, nodeB.next, nodeC.next, lengthDifference, isAorB);
            }
        }

        int GetLinkedListLength(ListNode listNode, int length)
        {
            if(listNode.next == null)
                return length;

            return GetLinkedListLength(listNode.next, length + 1);
        }


    }
}

