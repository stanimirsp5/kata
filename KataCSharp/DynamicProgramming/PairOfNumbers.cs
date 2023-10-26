namespace KataCSharp.DynamicProgramming
{
    public class PairOfNumbers
    {
        private List<int> sequence = new List<int> { 8, 10, 2, 9, 7, 5 };

        public void Start()
        {
            List<int> result = PairValues(13);
        }

        //In a technical interview, you've been given an array of numbers 
        //and you need to find a pair of numbers that are equal to the given target value. 
        //Numbers can be either positive, negative, or both. 
        //Can you design an algorithm that works in O(n)—linear time or greater?
        public List<int> PairValues(int num)
        {



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
    }
}
