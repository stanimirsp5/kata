using System;
namespace KataCSharp.Recursion
{
    public class PowerOfThree
    {
        int[] constants = new int[] { 3, 5, 7, 9 };
        public void Start()
        {
           var t = IsPowerOfThree(45);
           var t2 = IsPowerOfThree2(45);
        }

        public bool IsPowerOfThree2(int n)
        {
            if (n < 1) return false;
            while (n > 1)
            {
                if (n % 3 != 0)
                {
                    return false;
                }
                n /= 3;
            }
            return true;
        }

        public bool IsPowerOfThree(int n)
        {
            
            foreach (var c in constants)
            {
                bool isPower = FindPowerOfThree(n,c);
                if (isPower)
                {
                    return true;
                }
            }
            return false;
        }

        public bool FindPowerOfThree(int n, int constant)
        {
            if (n <= 0) return false;

            double tempNum = n;
            for (int i = 0; i < 3; i++)
            {
                tempNum = tempNum / constant;
            }

            //if (tempNum % 1 == 0) return true;
            if (tempNum == 1) return true;
            
            return false;
        }
    }
}

