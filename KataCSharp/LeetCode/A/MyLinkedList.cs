using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.LeetCode
{


    internal class MyLinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int d = 0)
            {
                val = d;
                next = null;
            }
        }

        public ListNode MergeLinkedLists(ListNode list1, ListNode list2)
        {
            ListNode merged = new ListNode();
            ListNode temp = merged;

            while (true)
            {
                if(list1 == null)
                {
                    temp.next = list2;
                    break;
                }
                if(list2 == null)
                {
                    temp.next = list1;
                    break;
                }


                if(list1.val <= list2.val)
                {
                    temp.next = list1;
                    list1 = list1.next;
                }
                else if(list2.val <= list1.val)
                {
                    temp.next = list2;
                    list2 = list2.next;
                }


                temp = temp.next;
            }

            return merged.next;

        }
        public bool IsPalindrome2(ListNode head)
        {
            ListNode fast = head, slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            if (fast != null)
            { // odd nodes: let right half smaller
                slow = slow.next;
            }
            slow = reverse(slow);
            fast = head;

            while (slow != null)
            {
                if (fast.val != slow.val)
                {
                    return false;
                }
                fast = fast.next;
                slow = slow.next;
            }
            return true;
        }

        public ListNode reverse(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                ListNode next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }
            return prev;
        }
        public bool IsPalindrome(ListNode head)
        {
            ListNode fast = head, slow = head;
            slow = slow.next;
            fast.next = fast.next.next;
            //newH = new ListNode(0);
            //ListNode reversedNode = REN(head);

            return true;//IPC(head, reversedNode);
        }
        public ListNode REN(ListNode original)
        {// reverse node
            if (original.next == null) return original;

            ListNode res = REN(original.next);

            original.next.next = original;
            original.next = null;
            return res;
        }
        public bool IPC(ListNode original, ListNode reversed)
        {// is palindrome check
            if (original == null && reversed == null)
            {
                return true;
            }
            if (original != reversed)
            {
                return false;
            }

            original = original.next;
            reversed = reversed.next;
            return IPC(original, reversed);
        }
      
        //[1,2,3]
        public ListNode ReverseLinkedList(ListNode list)
        {
            if(list == null ||
                list.next == null)
            {
                return list;
            }

            ListNode reversed = ReverseLinkedList(list.next);
            list.next.next = list;
            list.next = null;


            return reversed;
        }
        class Dog
        {
            public string Name { get; set; }
            public Dog DogChild { get; set; }

            public Dog(string name)
            {
                Name = name;
            }
        }
        public void ReferenceTest()
        {
            Dog dog = new Dog("Roro");
            var dog2 = dog;
            dog2 = new Dog("Maro");
            dog2.Name = "Sharo";
            Console.WriteLine(dog2.Name);
        } 
        public void ReferenceListTest(ListNode l1, ListNode l2)
        {
            var dummy = new ListNode(-1);
            dummy.next = l1;
            l1 = l1.next;
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var dummy = new ListNode(-1);

            var cur = dummy;
            var cur1 = l1;
            var cur2 = l2;

            while (cur1 != null && cur2 != null)
            {
                if (cur1.val <= cur2.val)
                {
                    cur.next = cur1;
                    cur1 = cur1.next;
                }
                else
                {
                    cur.next = cur2;
                    cur2 = cur2.next;
                }

                cur = cur.next;
            }

            while (cur1 != null)
            {
                cur.next = cur1;
                cur = cur.next;
                cur1 = cur1.next;
            }

            while (cur2 != null)
            {
                cur.next = cur2;
                cur = cur.next;
                cur2 = cur2.next;
            }

            var newHead = dummy.next;
            dummy.next = null;

            return newHead;
        }
    }
}

