using System;

namespace KataCSharp.LeetCode.B
{
    public class IncreasingTripletSubsequence
    {
        int[] array = new int[] { };
        public void Start()
        {
            var arr = new int[] { 20, 100, 10, 12, 5, 13 };
            //var arr = new int[] { 6, 7, 1, 2 };
            var res = FindTripletB(arr);
            //TODO solve with backtracking
        }

        [Theory]
        [InlineData(new int[] { 5, 2, 3, 4 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, true)]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, false)]
        [InlineData(new int[] { 2, 1, 5, 0, 4, 6 }, true)]
        [InlineData(new int[] { 6, 7, 1, 2 }, false)]
        [InlineData(new int[] { 1, 5, 0, 4, 1, 3 }, true)]
        [InlineData(new int[] { 20, 100, 10, 12, 5, 13 }, true)]
        [InlineData(new int[] { 1, 1, 1, 1 }, false)]
        public void FindTripletTest(int[] arr, bool expextedResult)
        {
            //bool result = FindTripletOneLoop(arr);
            //bool result = FindTripletB(arr);
            bool result = IncreasingTriplet(arr);
            Assert.Equal(expextedResult, result);
        }

        public bool FindTripletSearchAlgorith()
        {

            return false;
        }

        public bool FindTripletOneLoop(int[] arr)
        {
            // 1, 5, 0, 4, 1, 3
            // 6, 7, 1, 2
            int i = 0,
                j = 0,
                currNumIndex = 0,
                maxNum = -100,
                count = 0;

            while (true)
            {
                var currNum = arr[j];
                if (currNum > maxNum)
                {
                    maxNum = currNum;
                    count++;
                }

                if (count == 3)
                {
                    return true;
                }
                // when reach the end of the array
                // begin again from the next number after the max num
                if (j == arr.Length - 1)
                {
                    i++;
                    j = i;
                    maxNum = arr[currNumIndex];
                    count = 1;

                    if (i == arr.Length - 1)
                    {
                        maxNum = -100;
                        currNumIndex++;
                        j = currNumIndex - 1;
                        i = currNumIndex;
                        count = 0;
                        if (currNumIndex == arr.Length - 1) return false;
                    }
                }
                j++;
            }
        }

        public bool FindTripletB(int[] arr)
        {
            array = arr;
            for (int i = 0; i < array.Length; i++)
            {
                var tripletCount = FindTripletBacktracking(i, i, int.MinValue, 0);
                if (tripletCount == 3)
                    return true;
            }

            return false;
        }
        // 1, 5, 0, 4, 1, 3
        public int FindTripletBacktracking(int index, int currNumIndex, int maxNum, int tripletCount)
        {

            if (index == array.Length)
                return tripletCount;

            for (int i = index; i < array.Length; i++)
            {

                var currNum = array[i];
                if (currNum > maxNum)
                {
                    //currNumIndex = i;
                    maxNum = currNum;
                    tripletCount++;
                    if (tripletCount == 3)
                    {
                        return tripletCount;
                    }
                }

            }
            return FindTripletBacktracking(index += 1, currNumIndex, array[currNumIndex], 1);
        }

        public bool FindTriplet(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var k = 0;
                var count = 0;
                var maxNum = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (maxNum < arr[j])
                    {
                        maxNum = arr[j];
                        count++;
                    }

                    if (count == 2)
                    {
                        return true;
                    }

                    if (j == arr.Length - 1)
                    {
                        k++;
                        maxNum = arr[i];
                        j = i + k;
                        count = 0;
                    }
                }
            }
            return false;
        }

        public bool FindTriplet2(int[] arr)
        {
            int count = 0;
            int maxNum = arr[0];
            for (int i = 0, j = 1; j < arr.Length; i++, j++)
            {
                if (maxNum < arr[j])
                {
                    maxNum = arr[j];
                    count++;
                }

                if (count == 2) return true;
            }
            return false;
        }

        // 1, 5, 0, 4, 1, 3
        private bool IncreasingTriplet(int[] arr)
        {
            if (arr.Length < 3) return false;
            var smallest = int.MaxValue;
            var secondSmallest = int.MaxValue;

            foreach (var num in arr)
            {
                if (smallest >= num)
                {
                    smallest = num;
                }
                else if (secondSmallest >= num)
                {
                    secondSmallest = num;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        //1, 5, 0, 4, 1, 3
        public bool IncreasingTriplet2(int[] nums)
        {
            if (nums.Length < 3)
            {
                return false;
            }

            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int num in nums)
            {
                if (num <= smallest)
                {   // Find the smallest number
                    smallest = num;
                }
                else if (num <= secondSmallest)
                {  // If get here, this number is larger than smallest number
                    secondSmallest = num;
                }
                else
                {  // If get here, this number is larger than second smallest number => there is are increasing triplet
                    return true;
                }
            }

            return false;
        }
    }
}
