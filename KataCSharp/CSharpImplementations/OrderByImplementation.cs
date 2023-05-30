using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.CSharpImplementations
{
    public class OrderByImplementation
    {
        public void Start()
        {
            var list = new List<int>() { 7, 3, 1, 2, 9,  5, 6,  4, 8 };
            var res = list.OrderBy(x => x>5);
        }
    }

    public static class OrderByImpl
    {
        //public static IEnumerable<T> COrderBy<T>(this IEnumerable<T> source, Func<T, >)
        //{

        //}
    }

}
