using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.ProCSharpWithDotNET.Interfaces
{
    public interface IFunWithInterfaces
    {

        static IFunWithInterfaces()
        {

        }

    }

    class FunWithInterfaces
    {
        void Start()
        {
            var dog = new Dog();
            var cat = new Cat();
            var animals = new List<IWalk> { dog, cat };
            animals.ForEach(a => a.Walk());
        }
    }


    class Dog : IWalk
    {
        public void Walk()
        {
            throw new NotImplementedException();
        }
    }

    class Cat : IWalk
    {
        public void Walk()
        {
            throw new NotImplementedException();
        }
    }

    interface IWalk
    {
        void Walk();
    }
}
