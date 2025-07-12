namespace KataCSharp.Sandbox.CovarianceContravariance
{
    public class FunWithCovarianceAndContravariance
    {
		public void Start()
		{
			string str = "Hello, World!";
			object obj = str; 

			IEnumerable<string> strings = new List<string> { str };
			IEnumerable<object> objects = strings;// new List<object> { str };
			//covariance
			IEnumerable<Derived> derives = new List<Derived> { new Derived() };
			IEnumerable<Base> bases= derives;
			//contravariance - NO IEnumerable doesn't support contravariance
			//IEnumerable<Base> baseContra = new List<Base> { new Base() };
			//IEnumerable<Derived> derivesContra = baseContra;

			//contravariance
			Action<Base> baseAction = b => b.Display();
			//baseAction = (Derived d) => d.Display(); // This is valid due to contravariance in Action<T>


		}




		class Base
		{
			public virtual void Display()
			{
				Console.WriteLine("Base class display");
			}
		}

		class Derived : Base
		{
			public override void Display()
			{
				Console.WriteLine("Derived class display");
			}
		}
	}
}
