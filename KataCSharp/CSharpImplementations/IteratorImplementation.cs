using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.CSharpImplementations
{
    public class IteratorImplementation
    {




    }


    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }

    } 
    
    class Dogs : IEnumerable
    {
        private Dog[] _dogs;

        public Dogs(Dog[] dogs)
        {
            _dogs = new Dog[dogs.Length];
            for (int i = 0; i < dogs.Length; i++)
            {
                _dogs[i] = dogs[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
