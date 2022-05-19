using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.HackerRank
{
    internal class NewYearChaos
    {
        // 2,3,1,4
      
        public void LoopArray()
        {
            //List<int> arr = new List<int> { 2,5,1,3,4 };
            List<int> arr = new List<int> { 2,1,5,3,4 };
            //List<int> arr = new List<int> { 1, 2, 5, 3, 7, 8, 6, 4 }; //7
                                          //0  1  2  3  4  5  6  7
            //List<int> arr = new List<int> { 2, 3, 4, 1 };
           // List<int> arr = new() { 1,4,2,5,3};

            int n = arr.Count; // 8
            int numIndex, bribes, elementsBribedCount;
            bribes= elementsBribedCount = 0;

            for (int num = n; num > 0 ; num--)
            {
                int numDesiredPosition = num - 1; // length - 1 = 7
                numIndex = arr.IndexOf(num);// - elementsBribedCount;
                
                var biggestElementThanCurrNum = n - num;
                if (numIndex > numDesiredPosition) numIndex = (n - 1) - (numIndex - numDesiredPosition);// Math.Abs(biggestElementThanCurrNum - elementsBribedCount - numIndex);

                // if element is already at position don't move it
                if (numIndex == numDesiredPosition) continue;
               
                if(numIndex + 1 == numDesiredPosition)
                {
                    bribes++;
                }
                else if(numIndex + 2 == numDesiredPosition)
                {
                    bribes += 2;
                }
                else 
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                elementsBribedCount++;

            }
            Console.WriteLine(bribes);
        } 
        public void SortMaxArray2()
        {
            //List<int> arr = new List<int> { 2,5,1,3,4 };
            List<int> arr = new List<int> { 2,1,5,3,4 };
           // List<int> arr = new List<int> { 1, 2, 5, 3, 7, 8, 6, 4 };
            //List<int> arr = new List<int> { 1, 4,  3, 2 };
            //List<int> arr = new() { 5, 1, 2,3,7,8,6,4 };

            int n = arr.Count;
            int bribes = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                //maxIndex = arr.IndexOf(i+1);
                //var (maxNum, maxIndex) = arr.Select((n, i) => (n, i)).Max();
                // 1 , 4 , 3, 2 / 3
                if (arr[i] != i+1)
                {
                    if (arr[i-1] == i+1) {
                        var maxNum = arr[i - 1];

                        arr[i - 1] = arr[i];
                        arr[i] = maxNum;
                        bribes++;
                    }else if(arr[i - 2] == i + 1)
                    {
                        var maxNum = arr[i - 2];

                        arr[i - 2] = arr[i - 1]; 
                        arr[i - 1] = arr[i];
                        arr[i] = maxNum;
                        bribes+=2;
                    }else
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                }

            }
            Console.WriteLine(bribes);
        }  
        public void SortMaxArray3()
        {
           // List<int> arr = new List<int> { 2,5,1,3,4 };
           // List<int> arr = new List<int> { 1, 2, 5, 3, 7, 8, 6, 4 };
            List<int> arr = new List<int> { 1, 2,  3, 4 };
            //List<int> arr = new() { 5, 1, 2,3,7,8,6,4 };

            int n = arr.Count;
            int totalBribes, maxIndex, bribes;
            totalBribes = 0;

            for (int i = n - 1; i >= 0 ; --i)
            {
                maxIndex = arr.IndexOf(i+1);
                bribes = 0;
                while (maxIndex != i)
                {
                    var maxNum = arr[maxIndex];
                    arr[maxIndex] = arr[maxIndex+1];
                    arr[maxIndex + 1] = maxNum;

                    maxIndex++;
                    bribes++;
                    if(bribes > 2)
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                }

                totalBribes += bribes;
            }
            Console.WriteLine(totalBribes);
        } 
        public void SortMaxArray()
        {
           // List<int> arr = new List<int> { 2,5,1,3,4 };
           // List<int> arr = new List<int> { 1, 2, 5, 3, 7, 8, 6, 4 };
            List<int> arr = new List<int> { 1, 2,  3, 4 };
            //List<int> arr = new() { 5, 1, 2,3,7,8,6,4 };

            int n = arr.Count;
            int totalBribes, maxIndex, bribes;
            totalBribes = 0;

            for (int i = n - 1; i >= 0 ; --i)
            {
                maxIndex = arr.IndexOf(i+1);
                bribes = 0;
                while (maxIndex != i)
                {
                    var maxNum = arr[maxIndex];
                    arr[maxIndex] = arr[maxIndex+1];
                    arr[maxIndex + 1] = maxNum;

                    maxIndex++;
                    bribes++;
                    if(bribes > 2)
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                }

                totalBribes += bribes;
            }
            Console.WriteLine(totalBribes);
        }
        void InsertionSort(int[] arr) //[ 2,3,4,1]
        {
            int n = arr.Length; // 4
            for (int i = 1; i < n; ++i)// 3
            {
                int key = arr[i];//1
                int j = i - 1;//2

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)// 4>1, 3>1, 2>1
                {
                    arr[j + 1] = arr[j];// 1=4, 1 = 3, 1 = 2
                    j = j - 1;// 1, 0, -1
                }
                arr[j + 1] = key; // 2=1
            }
        }
        public void SortArray()
        {
            List<int> q = new List<int> { 1, 2, 5, 3, 7, 8, 6, 4, };
            //List<int> q = new List<int> {  1, 2, 3, 5, 4, 6, 7, 8 };

            List<KeyValuePair<int, int>> arr = q.Select(el => new KeyValuePair<int, int>(el, 0)).ToList();

            int n = arr.Count;
            int bribesCount = 0;
            for (int i = 0; i < n - 1; i++)
            {
                // find index of smallest number 
                int minIndex = i;
                for (int k = i + 1; k < n; k++)
                {
                    if (arr[k].Key < arr[minIndex].Key)
                    {
                        minIndex = k;
                    }
                }

                if (minIndex == 0 ||
                    arr[minIndex].Key > arr[minIndex-1].Key) continue;

                bribesCount++;

                // number can swap position with another only 2 times
                if (arr[minIndex].Value + 1 == 3 || arr[minIndex - 1].Value + 1 == 3)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                // move smallest number by one position
                // increase max num movement speed by 1 on both numbers
                var smallestValue = new KeyValuePair<int, int>(arr[minIndex].Key, arr[minIndex].Value + 1);
                arr[minIndex] = new KeyValuePair<int, int>(arr[minIndex - 1].Key, arr[minIndex - 1].Value + 1);
                arr[minIndex - 1] = smallestValue;
                i--;
            }
            Console.WriteLine(bribesCount);
        }
        public static void minimumBribes(List<int> q)
        {
            int bribes = 0;
            bool chaotic = false;
            bool bribebacks = false;

            for (int i = 1; i < q.Count; i++)
            {

                if (bribebacks)
                {
                    bribes += q[i - 1] == i ? 1 : 0;
                    bribebacks = false;
                    continue;
                }

                if (i > q[i - 1])
                {
                    continue;
                }
                else
                {
                    if ((q[i - 1] - i) > 2)
                    {
                        chaotic = true;
                        break;
                    }
                    if ((q[i - 1] - i) == 2)
                    {
                        bribebacks = true;
                    }

                    bribes += q[i - 1] - i;
                }
            }

            if (chaotic)
            {
                Console.WriteLine("Too chaotic");
            }
            else
            {
                Console.WriteLine(bribes);
            }
        }
    }
}
