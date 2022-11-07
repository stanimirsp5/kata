using AlgorithmsSoftuni.CodingGames.OrderOfSuccession;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;
//using Xunit;

namespace KataCSharp.CSharpImplementations
{
    //https://codeblog.jonskeet.uk/2010/12/27/reimplementing-linq-to-objects-part-9-selectmany/
    public abstract class SelectManyImplementation
    {
        public void Start()
        {
            // FlattenWithProjectionAndIndex();

            //CallSelect();
            PrintString myDelegate = Func2;

            Func<string, string> funcDelegate = s => "name: " + s;

            var t = myDelegate("Stan");
            var t2 = funcDelegate("Stan");
        }
        public delegate string PrintString(string s);
        public abstract string PrintString1(string s);




        void AccDel(PrintString ps1)
        {
            ps1("test");
        }
        string Func2(string str)
        {
            var r = str + "1";
            return r;
        }
        string GetName(Func<string,string> func)
        {


            return "";
        }

        // [Fact]
        public static void FlattenWithProjectionAndIndex()
        {
            int[] numbers = { 3, 5, 20, 15 };
            var query = numbers.SelectMany((x, index) => (x + index).ToString().ToCharArray(),
                                           (x, c) => x + ": " + c);
            
            var query2 = numbers.SelectMany((x, index) => (index).ToString());
            // 3 => "3: 3"
            // 5 => "5: 6"
            // 20 => "20: 2", "20: 2"
            // 15 => "15: 1", "15: 8"
            //query.SequenceEqual(new List<string> { "3: 3", "5: 6", "20: 2", "20: 2", "15: 1", "15: 8" });
            //var t =SelectManyImpl(numbers, (x) => x);
            Func<string, string> selector = str => str.ToUpper();
            var str = selector("test");


            List<int> list= new List<int> { 3, 5, 20, 15 };
            //var r = list.Select(l => l);
            //var tt = SelectImpl(list, el => el + "t");
            //tt.ToList();
            // YieldTest(5);
            Console.WriteLine("test2");

        }

        static void CallSelect()
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            Func<int, bool> selector = n => n > 1;
            Func<IEnumerable<int>, IEnumerable<int>> selector2 = list => list;
            
           // var res = SelectImpl(list, selector2);

        }

        private static IEnumerable<TResult> SelectImpl<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        {

            foreach (TSource item in source)
            {
                foreach (TResult result in selector(item))
                {
                    yield return result;
                }
            }

           // var t = selector(source.First());    
            //return t;
        }


        static void CallYield()
        {
            var numbers = YieldTest(5);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        static IEnumerable<int> YieldTest(int num)
        {
            for (int i = 0; i < num; i++)
            {
                yield return i;
            }
        }


        //private IEnumerable<TResult> SelectManyImpl<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        //{
        //    Console.WriteLine("test");
        //    foreach (TSource item in source)
        //    {
        //        foreach (TResult result in selector(item))
        //        {
        //            yield return result;
        //        }
        //    }
        //}

        //private IEnumerable<TResult> SelectManyImpl2<TSource, TResult>(
        //    IEnumerable<TSource> source,
        //    Func<TSource, IEnumerable<TResult>> selector)
        //{
        //    foreach (TSource item in source)
        //    {
        //        foreach (TResult result in selector(item))
        //        {
        //            yield return result;
        //        }
        //    }
        //}

        public delegate int Del1(int a, int b);
        public int SumNumders(int a, int b)
        {
            return a + b;
        }

        public void DelMethod()
        {
            //1
            var sum = new Del1(SumNumders);
            var rsum = sum(1, 2);

                //1.2
                Del1 sum12 = SumNumders;
                var rsum12 = sum12(1, 2);

            //2
            Del1 sum2 = (a,b) => a + b;
            var rsum2 = sum2(1, 2);

            //3
            var sum3 = delegate (int a, int b)
            {
                return a + b;
            };
            var rsum3 = sum3(1, 2);

            //4
            Del1 sum4 = (a, b) =>
            {
                return a + b;
            };
        }
    }

    public static class Queries
    {
        public static void MyMain()
        {
           // Func<IEnumerable<int>, bool> selector = x => x. > 0;

        }

        //public static IEnumerable<T> Where2<T>(this IEnumerable<T> source, Func<IEnumerable<int>, bool> selector)
        public static IEnumerable<int> Where2 (this IEnumerable<int> source, Func<int, bool> predicate)
        {
            //var newColection = new List<int>();
            foreach (var item in source)
            {
                if(predicate(item))
                {
                    //newColection.Add(item);
                    yield return item;
                }
            }
            //return newColection;
        }

    }
}
