using System;
using System.Numerics;
using KataCSharp.LeetCode.LinkedLists;

namespace KataCSharp.Recursion
{
    public class AddTwoNumbers
    {
        private string numStr = string.Empty;
        public void Start()
        {
            //int[] arr1 = new int[] { 2, 4, 3 };
            int[] arr1 = new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            var list1 = ListNode.LinkedListFromArray(arr1);
            //int[] arr2 = new int[] { 5,6,4 };
            int[] arr2 = new int[] { 5, 6, 4 };
            var list2 = ListNode.LinkedListFromArray(arr2);

            AddTwoNumbersM(list1, list2);
        }

        public ListNode AddTwoNumbersM(ListNode l1, ListNode l2)
        {
            BigInteger nums1 = BigInteger.Parse(GetNums(l1));
            numStr = string.Empty;
            BigInteger nums2 = BigInteger.Parse(GetNums(l2));

            var num3 = (nums1 + nums2).ToString();
            var l3 = LinkedListFromString(num3);
            return l3;
        }

        string GetNums(ListNode linkedList)
        {
            if (linkedList == null)
                return "";

            GetNums(linkedList.next);

            numStr += linkedList.val.ToString();

            return numStr;
        }

        ListNode LinkedListFromString(string str)
        {
            ListNode linkedList = new ListNode();
            linkedList.val = int.Parse(str[str.Length-1].ToString());
            if (str.Length > 1)
                linkedList.next = new ListNode();

            for (int i = str.Length - 2; i >= 0; i--)
            {
               var lastNode = GetLastNode(linkedList);
                lastNode.val = int.Parse(str[i].ToString());
                if(i != 0)
                    lastNode.next = new ListNode();
            }
            return linkedList;
        }

        ListNode GetLastNode(ListNode linkedList)
        {
            if (linkedList.next == null)
                return linkedList;
            
            var lastNode = GetLastNode(linkedList.next);
            return lastNode;
        }
    }
}

