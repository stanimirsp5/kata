using System;
using System.Collections;

namespace KataCSharp.ProCSharpWithDotNET.IEnumerableAndIEnumerator;

class FunWithEnumerator
{
    public void Start()
    {
        var garage = new Garage();
        foreach (Car car in garage)
        {
            Console.WriteLine(car.Model);
        }
        // compile time error. Explicitly interface implementation doesn't allow direct method access.
        //var carEnumerator = garage.GetEnumerator();
        // Explicit cast is needed.
        if (garage is IEnumerable enumerableGarage2)
        {
            var carEnumeratore = enumerableGarage2.GetEnumerator();
        }
        var enumerableGarage = garage as IEnumerable;
        var carEnumerator = enumerableGarage.GetEnumerator();
        carEnumerator.MoveNext();
        var firstCar = carEnumerator.Current;
    }


    class Car(string model)
    {
        public string Model { get; } = model;
    }
    
    class Garage : IEnumerable
    {
        private Car[] cars;

        public Garage()
        {
            cars = new Car[3];
            cars[0] = new Car("BMW");
            cars[1] = new Car("Toyota");
            cars[2] = new Car("Mercedes");
        }

        IEnumerator IEnumerable.GetEnumerator() => cars.GetEnumerator();
    }
}