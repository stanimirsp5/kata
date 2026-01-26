//https://learn.microsoft.com/en-us/dotnet/csharp/event-pattern Standard .NET event patterns
//https://learn.microsoft.com/en-us/dotnet/csharp/events-overview
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/event
// EventHandler and why there is no need to define custom delegate types for events
namespace KataCSharp.ProCSharpWithDotNET.DelegatesAndEvents
{
	public class FunWithEvents
	{
		public void Start()
		{
			var car1 = new Car("SlugBug", 100, 10);
			//car1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
			car1.AboutToBlow += CarIsAlmostDoomed;
			car1.AboutToBlow += CarAboutToBlow;

			EventHandler<CarEventArgs> d = CarExlpoded;
			car1.Exploded += d;

			Console.WriteLine("**** Speeding up ****");
			for (int i = 0; i < 6; i++)
			{
				car1.AccelerateWithEvent(20);
			}

			car1.Exploded -= d;

			Console.WriteLine("**** Speeding up ****");
			for (int i = 0; i < 6; i++)
			{
				car1.AccelerateWithEvent(20);
			}

			Console.ReadLine();
		}

		static void OnCarEngineEvent(string msg)
		{
			Console.WriteLine("\n*** Message From Car Object ***");
			Console.WriteLine("=> {0}", msg);
			Console.WriteLine("*************\n");
		}

		static void CarAboutToBlow(object sender, CarEventArgs e)
		{
			if (sender is Car car)
				Console.WriteLine("{0} says: {1}", car.PetName, e.msg);
			else
				Console.WriteLine(sender + " says: " + e.msg);
		}

		static void CarIsAlmostDoomed(object sender, CarEventArgs e)
		{
			Console.WriteLine("Critical message from Car: {0}", e.msg);
		}

		static void CarExlpoded(object sender, CarEventArgs e)
		{
			if (sender is Car car)
				Console.WriteLine("{0} CarExploded: {1}", car.PetName, e.msg);
			else
				Console.WriteLine(sender + " CarExploded: " + e.msg);
		}

		public class Car
		{
			public int CurrentSpeed { get; set; }
			public int MaxSpeed { get; set; }
			public string PetName { get; set; }

			private bool _carIsDead;
			private CarEngineHandler _listOfHandlers;

			public Car() { }
			public Car(string name, int maxSp, int currSp)
			{
				CurrentSpeed = currSp;
				MaxSpeed = maxSp;
				PetName = name;
			}


			public delegate void CarEngineHandler(object sender, CarEventArgs e);

			public event EventHandler<CarEventArgs> Exploded;
			public event EventHandler<CarEventArgs> AboutToBlow;

			public void RegisterWithCarEngine(CarEngineHandler methodCall)
			{
				_listOfHandlers = methodCall;
			}

			// public void Accelerate(int delta)
			// {
			// 	if (_carIsDead)
			// 		_listOfHandlers?.Invoke("Sorry, this car is dead");
			// 	else
			// 		CurrentSpeed += delta;

			// 	if (10 == (MaxSpeed - CurrentSpeed))
			// 		_listOfHandlers?.Invoke("Careful buddy! Gonna blow!");

			// 	if (CurrentSpeed >= MaxSpeed)
			// 		_carIsDead = true;
			// 	else
			// 		Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
			// }

			public void AccelerateWithEvent(int delta)
			{
				if (_carIsDead)
					Exploded?.Invoke(this, new CarEventArgs("Sorry, this car is dead"));
				else
					CurrentSpeed += delta;

				if (10 == (MaxSpeed - CurrentSpeed))
					AboutToBlow?.Invoke(this, new CarEventArgs("Careful buddy! Gonna blow!"));

				if (CurrentSpeed >= MaxSpeed)
					_carIsDead = true;
				else
					Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
			}

		}

		public class CarEventArgs : EventArgs
		{
			public readonly string msg;
			public CarEventArgs(string message)
			{
				msg = message;
			}
		}
	}
}
