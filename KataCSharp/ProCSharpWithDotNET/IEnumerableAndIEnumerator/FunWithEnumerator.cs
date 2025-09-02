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


        var guards = new GuardsIEnumerator();
        guards.IterateAddresses();
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

    class Address : IEnumerable
	{
		public string Street { get; set; }
		public string City { get; set; }

        //public IEnumerator GetEnumerator()
        //{
        //    throw new NotImplementedException();

        //    yield return new Address { Street = "123 Main St", City = "Anytown" };
        //    yield return new Address { Street = "456 Oak Ave", City = "Othertown" };
        //    yield return new Address { Street = "789 Pine Rd", City = "Sometown" };
        //}

        // With exception guard
        public IEnumerator GetEnumerator()
		{
			//throw new NotImplementedException();

            return ActualImplementation();


			IEnumerator ActualImplementation()
            {
				yield return new Address { Street = "123 Main St", City = "Anytown" };
				yield return new Address { Street = "456 Oak Ave", City = "Othertown" };
				yield return new Address { Street = "789 Pine Rd", City = "Sometown" };
			}
		}
	}


	class GuardsIEnumerator
    {
        public void IterateAddresses()
		{
            var addresses = new Address();
			// Using IEnumerator to iterate through the collection
			IEnumerator enumerator = addresses.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Address address = (Address)enumerator.Current;
				Console.WriteLine($"{address.Street}, {address.City}");
			}
		}
    }
}