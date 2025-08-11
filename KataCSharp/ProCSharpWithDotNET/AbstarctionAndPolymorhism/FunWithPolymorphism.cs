namespace KataCSharp.ProCSharpWithDotNET.AbstarctionAndPolymorhism;

public class FunWithPolymorphism
{
	public void Start()
	{
		var circle = new Circle();
		var square = new Square();
		circle.Draw("Circle");
		square.Draw("Square");

	}


	abstract class Shape
	{
		public virtual void Draw(string shape) {
			Console.WriteLine("Draw shape: " + shape);
		}
	}

	class Circle : Shape
	{
		
	}

	class Square : Shape
	{
		public override void Draw(string shape)
		{
			Console.WriteLine("Draw square shape: " + shape);
		}
	}

}
