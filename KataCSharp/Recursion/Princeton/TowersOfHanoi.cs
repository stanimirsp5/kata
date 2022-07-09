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

            //for (int i = n; i >= 1; i--)
            //{
            //    A.Push(i);
            //}
            //Run();
            TOH(3, 'A', 'B', 'C');
        }
        void TOH(int n, char a, char b, char c)
        {
            if (n <= 0) return;
            TOH(n - 1, a, c, b);
            Console.WriteLine($"Move {n} from {a} to {c}");
            TOH(n - 1,b,a,c);
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

        void Tower(int discNum, char from, char aux, char to)
        {
            if (discNum == 1)
            {
                Console.WriteLine("Move disc {0} from {1} to {2}", discNum, from,to);
                return;
            }
            else
            {
                Tower(discNum - 1,from,to,aux);
                Console.WriteLine("Move disc {0} from {1} to {2}", discNum, from, to);

                Tower(discNum-1,aux,from,to);
            }
        }

        void Hanoi()
        {
            if(A.Count == 1)
            {
                C.Push(A.Pop());
            }
            else
            {
                Hanoi();

            }
        }

    }
}

