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
    public static class SelectManyImplementation
    {
        public static void Start()
        {
            // FlattenWithProjectionAndIndex();

            CallSelect();
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
            //Func<bool, IEnumerable<int>> selector = n => n > 1;
            //var res = SelectImpl(list,);

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

    }
}
