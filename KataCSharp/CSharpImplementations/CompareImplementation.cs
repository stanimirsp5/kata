using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KataCSharp.CSharpImplementations.CompareImplementation;

namespace KataCSharp.CSharpImplementations
{
    public class CompareImplementation
    {
       public class Cube
        {
            public int length, breadth, height;
            public Cube(int length, int breadth, int height)
            {
                this.length = length;
                this.breadth = breadth;
                this.height = height;
            }
        }

        public class CompareDimension : Comparer<Cube>
        {
            public override int Compare(Cube c1, Cube c2)
            {
                var res = c1.length.CompareTo(c2.length);
                if (res == 0)
                {
                    res = c1.breadth.CompareTo(c2.breadth);
                    if(res == 0)
                    {
                        res = c1.height.CompareTo(c2.height);
                    }
                }
                return res;
            }
        }

        public class CompareVolume : Comparer<Cube>
        {
            public override int Compare(Cube c1, Cube c2)
            {
                var v1 = c1.length * c1.breadth * c1.height;
                var v2 = c2.length * c2.breadth * c2.height;
                var res = v1.CompareTo(v2);

                return res;
            }
        }


        /// <summary>
        /// Task
        /// A class Cube is defined for you.Define two comparers in the code editor.
        ///CompareDimension: It sorts ascending for the length first.If the lengths are equal, sort descending for breadth.If both are equal, sort ascending for height.
        ///CompareVolume: It sorts ascending according to the volume of the cube.
        /// </summary>
        class MAIN
        {
            public static void Main(string[] args)
            {
                List<Cube> l1 = new List<Cube>();
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    String[] temp = Console.ReadLine().Split(' ');
                    int l = Convert.ToInt32(temp[0]);
                    int b = Convert.ToInt32(temp[1]);
                    int h = Convert.ToInt32(temp[2]);
                    l1.Add(new Cube(l, b, h));
                }
                l1.Sort(new CompareDimension());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(l1[i].length + " " + l1[i].breadth + " " + l1[i].height);
                }
                l1.Sort(new CompareVolume());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(l1[i].length + " " + l1[i].breadth + " " + l1[i].height);
                }
            }
        }




    }
}
