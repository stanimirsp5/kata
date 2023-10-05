using System;
using KataCSharp.LeetCode.LinkedLists;

namespace KataCSharp.Common
{
    public static class CommonMethods
    {
        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void PrintArray<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void PrintArray<T>(List<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        public static void PrintLinkedList(ListNode node)
        {
            if (node == null)
            {
                Console.WriteLine();
                return;
            }

            Console.Write(node.val + " ");

            PrintLinkedList(node.next);
        }
    }
}