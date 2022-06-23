using System;
namespace KataCSharp.Recursion.Princeton
{
    public class Fibonnacci
    {

        public void Start()
        {
            //  Fib(0,1,0,5);
            // ReverseFib(2,3);
           int t = Factorial(5);
           int gcd = GCD(6,4,1);
        }
        // 1,1,2,3,5,8,13,21,34,55,89,139
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
        int Factorial(int num)
        {
            if (num == 1) return 1;
            return Factorial(num - 1) * num;

        }
        //Euclid's algorithm greatest common divicor
        //4,6
        int GCD(int a, int b, int gcd)
        {

            if(a%gcd != 0 || b%gcd != 0)
            {
            //Console.WriteLine(gcd);
                return gcd-1;
            }

            return GCD(a / gcd, b / gcd, gcd + 1);

        }

    }
}

//0,1,1,3
//1,1,2,3
//1,2,3,3