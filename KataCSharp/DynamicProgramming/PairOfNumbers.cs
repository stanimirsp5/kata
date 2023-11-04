using System;
namespace KataCSharp.DynamicProgramming
{
    public class PairOfNumbers
    {
        private List<int> sequence = new List<int> { 8, 10, 2, 9, 7, 5 };

        public void Start()
        {
            // List<int> result = PairValues(11);
            var t = PrintFibonnacciMemorizedAproach(6);
        }

        //In a technical interview, you've been given an array of numbers 
        //and you need to find a pair of numbers that are equal to the given target value. 
        //Numbers can be either positive, negative, or both. 
        //Can you design an algorithm that works in O(n)—linear time or greater?
        public List<int> PairValues(int num)
        {
            var set = new HashSet<int>();
            foreach (var currNum in sequence)
            {
                var neededNum = num - currNum;
                if (set.Contains(neededNum))
                {
                    return new List<int> { currNum, neededNum };
                }
                set.Add(currNum);
            }
            return new List<int>();
        }

        public List<int> PairValuesBruteForce(int num)
        {
            for (int i = 0; i < sequence.Count; i++)
            {
                var seqNum = sequence[i];
                var tempNum = num - seqNum;
                for (int j = 0; j < sequence.Count; j++)
                {
                    if (i == j) continue;

                    if (tempNum - sequence[j] == 0)
                    {
                        return new List<int> { seqNum, sequence[j] };
                    }
                }
            }
            return new List<int>();
        }

        // 0,1,1,2,3,5,8,13
        public int PrintFibonnacci(int num)
        {
            if (num < 2)
            {
                return num;
            }
            else
            {
                var res = PrintFibonnacci(num - 1) + PrintFibonnacci(num - 2);
                return res;
            }
        }

        public int PrintFibonnacciMemorizedAproach(int num)
        {
            int prevNum = 0;
            int currNum = 1;

            while (currNum <= num)
            {
                int tempNum = currNum;
                currNum = prevNum + currNum;
                prevNum = tempNum;
                Console.Write(currNum + " ");
            }

            return currNum;
        }
    }
}
