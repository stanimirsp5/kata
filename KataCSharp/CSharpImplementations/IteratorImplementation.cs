using KataCSharp.CSharpImplementations.SelectMany;
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

        public void Start()
        {

            ComposeCollections();

        }
        void ComposeCollections()
        {

            var cats = new List<Cat>();
            Cat[] cats2 = new Cat[10];
            
            foreach (var cat in cats2)
            {
                Console.WriteLine(cat);
            }
            Dog[] dog = new Dog[10];

        }

    }


    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }

    } 
    class Cat
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
            return GetEnumerator();
        }

        public DogEnum GetEnumerator()
        {
            return new DogEnum(_dogs);
        }
    }

    class DogEnum : IEnumerator
    {
        public Dog[] _dog;
        int position = -1;

        public DogEnum(Dog[] dog)
        {
            _dog = dog;
        }

        public bool MoveNext()
        {
            position++;
            return position < _dog.Length;
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Dog Current
        {
            get
            {
                try
                {
                    return _dog[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
