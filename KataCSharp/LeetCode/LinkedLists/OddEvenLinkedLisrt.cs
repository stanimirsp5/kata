using System;
using static Kata.LeetCode.MyLinkedList;

namespace KataCSharp.LeetCode.LinkedLists
{
    public class OddEvenLinkedLisrt
    {
        public void Start()
        {
            //int[] arr = new int[] {1,2,3,4,5};
            //int[] arr = new int[] { 2, 1, 3, 5, 6, 4, 7 };
            int[] arr = new int[] {1, 2,3,4};
            var listNode = ListNode.LinkedListFromArray(arr);
           // OddEvenList(listNode);
            OddEvenListLoop(listNode);
        }

        public ListNode OddEvenList(ListNode head)
        {
            var oddList = new ListNode();
            var evenList = new ListNode();
            (oddList, evenList) = GetNodes(head, oddList, evenList, 1);
            var res = GetLastNode(oddList);
            res.next = evenList;
            return oddList;
        }

        (ListNode, ListNode) GetNodes(ListNode head, ListNode oddList, ListNode evenList, int index)
        {
            if (head == null) return (oddList, evenList);

            if(index % 2 == 0)
            {
                evenList.val = head.val;
                if(head.next != null && head.next.next != null)
                    evenList.next = new ListNode();
                GetNodes(head.next, oddList, evenList.next, index + 1);
            }
            else
            {
                oddList.val = head.val;
                if(head.next != null && head.next.next != null)
                    oddList.next = new ListNode();
                GetNodes(head.next, oddList.next, evenList, index + 1);
            }

            return (oddList,evenList);
        }

        ListNode GetLastNode(ListNode node)
        {
            if (node.next == null) return node;
            return GetLastNode(node.next);
        }

        ListNode OddEvenListLoop(ListNode node)
        {
            if (node == null) return null;
            ListNode oddList = node, evenList = node.next, evenHead = evenList;

            while (evenList != null && evenList.next != null)
            {
                oddList.next = evenList.next;
                oddList = oddList.next;

                evenList.next = oddList.next;
                evenList = evenList.next;
            }
            oddList.next = evenHead;
            return node;
        }
    }

}

