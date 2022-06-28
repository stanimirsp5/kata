using System;
namespace KataCSharp.Recursion.Princeton
{
    public class TowersOfHanoi
    {
        Stack<int> A = new Stack<int>();
        Stack<int> B = new Stack<int>();
        Stack<int> C = new Stack<int>();

        public void Start()
        {
            int n = 3;

            for (int i = n; i >= 1; i--)
            {
                A.Push(i);
            }
            Run();
        }


        void Run()
        {
            if(A.Count - 1 == 0) // last element
            {
                C.Push(A.Pop());
                return;
            }
            else
            {
                B.Push(A.Pop());
            }

            Run();

            C.Push(B.Pop());
        }

    }
}

