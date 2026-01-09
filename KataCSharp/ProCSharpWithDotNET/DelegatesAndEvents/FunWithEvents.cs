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

			Car.CarEngineHandler d = CarExlpoded;
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

		static void CarAboutToBlow(string msg)
		{
			Console.WriteLine("CarAboutToBlow: " + msg);
		}

		static void CarIsAlmostDoomed(string msg)
		{
			Console.WriteLine("Critical message from Car: {0}", msg);
		}

		static void CarExlpoded(string msg)
		{
			Console.WriteLine("CarExlpoded: " + msg);
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


			public delegate void CarEngineHandler(string msgForCaller);

			public event CarEngineHandler Exploded;
			public event CarEngineHandler AboutToBlow;

			public void RegisterWithCarEngine(CarEngineHandler methodCall)
			{
				_listOfHandlers = methodCall;
			}

			public void Accelerate(int delta)
			{
				if (_carIsDead)
					_listOfHandlers?.Invoke("Sorry, this car is dead");
				else
					CurrentSpeed += delta;

				if (10 == (MaxSpeed - CurrentSpeed))
					_listOfHandlers?.Invoke("Careful buddy! Gonna blow!");

				if (CurrentSpeed >= MaxSpeed)
					_carIsDead = true;
				else
					Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
			}

			public void AccelerateWithEvent(int delta)
			{
				if (_carIsDead)
					Exploded?.Invoke("Sorry, this car is dead");
				else
					CurrentSpeed += delta;

				if (10 == (MaxSpeed - CurrentSpeed))
					AboutToBlow?.Invoke("Careful buddy! Gonna blow!");

				if (CurrentSpeed >= MaxSpeed)
					_carIsDead = true;
				else
					Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
			}

		}

	}
}
