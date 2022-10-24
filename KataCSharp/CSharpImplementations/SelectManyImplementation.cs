using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Xunit;

namespace KataCSharp.CSharpImplementations
{
    //https://codeblog.jonskeet.uk/2010/12/27/reimplementing-linq-to-objects-part-9-selectmany/
    public class SelectManyImplementation
    {
        public void Start()
        {
            FlattenWithProjectionAndIndex();
        }


       // [Fact]
        public void FlattenWithProjectionAndIndex()
        {
            int[] numbers = { 3, 5, 20, 15 };
            var query = numbers.SelectMany((x, index) => (x + index).ToString().ToCharArray(),
                                           (x, c) => x + ": " + c);
            
           // var query2 = numbers.SelectMany((x, index) => (x + index));
            // 3 => "3: 3"
            // 5 => "5: 6"
            // 20 => "20: 2", "20: 2"
            // 15 => "15: 1", "15: 8"
            query.SequenceEqual(new List<string> { "3: 3", "5: 6", "20: 2", "20: 2", "15: 1", "15: 8" });
        }





    }
}
