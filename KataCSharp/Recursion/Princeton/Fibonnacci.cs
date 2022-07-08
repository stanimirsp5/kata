using System;
namespace KataCSharp.Recursion.Princeton
{
    public class Fibonnacci
    {

        public void Start()
        {
            //Fib(0,1,0,5);
            // Fib2(5, 0, 0, 1);
            Perm("ABC", 0, 0);
            //Console.Write(FibMultipeRecursion(5));
            // ReverseFib(2,3);
            //int t = Factorial(5);
            //int gcd = GCD(12,8);
            //int gcdIterate = GCD2(100,80);
        }
        // 1,1,2,3,5,8,13,21,34,55,89,139
        void Perm(string str, int i,int n)
        {
            if(str.Length <= n)
            {
                //i += 1;
                Console.WriteLine();
                return;
            }
            Console.Write(str[i]);
            Perm(str, i+1, n+1);
            Console.Write(str[i]);
        }
        void Fib(int a,int b, int count,int length)//0,1,1,3
        {
            if (count != length)
            {
                Console.Write(b + " ");
                Fib(b, a+b, count+=1,length);
            }
        }
        void ReverseFib(int num1, int num2)
        {
            if(num1 > -1)
            {
                Console.Write(num2 + " ");
                ReverseFib(num2 - num1, num1);
            }
        }
        
        void Fib2(int n,int count,int a,int b)//5,0,0,1
        {
            if(count== n)
            {
                return;
            }
            Console.Write(b+" ");
            int t = a+b;
            Fib2(n, count+1,b,t);

        }
        int FibMultipeRecursion(int n)//5
        {
           
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else
            {
                int f1 = FibMultipeRecursion(n - 1);
                int f2 = FibMultipeRecursion(n - 2);
                int res = f1 + f2;
                return res;
            }
            
        }
        int Factorial(int num)
        {
            if (num == 1) return 1;
            return Factorial(num - 1) * num;

        }
        //Euclid's algorithm greatest common divicor
        //4,6
        int GCD(int a, int b)//10,8
        {
            if(b == 0)
            {
                return a;
            }
           return GCD(b, a%b);
        }
        int GCD2(int a,int b)//6,4
        {

            while (true)
            {
                int temp = a % b;
                
                if (temp == 0)
                {
                    break;
                }
                a = b;
                b = temp;

            }

            return b;
        }

    }
}

//0,1,1,3
//1,1,2,3
//1,2,3,3