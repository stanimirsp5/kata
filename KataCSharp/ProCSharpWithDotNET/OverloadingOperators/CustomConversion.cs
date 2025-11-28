using KataCSharp.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.ProCSharpWithDotNET.OverloadingOperators
{
	public class CustomConversion
	{
		public void Start()
		{
			CustomConverte();
		}

		public void CustomConverte()
		{
			var square = new Square(5);
			var rectangle = new Rectangle(4,6);

			var rectangleFromSquare = (Rectangle)square;
			rectangle = square;


		}
	}

	public class Square
	{
		public int Side { get; set; }

		private int _area;

		public int Area
		{
			get => _area;

			set { _area = (int)Math.Sqrt(Side); }
		}

		public Square(int side)
		{
			Side = side;
		}

		public static implicit operator Rectangle(Square sq)
		{
			return new Rectangle(sq.Side, sq.Side);
		}

		//public static explicit operator Rectangle(Square sq)
		//{
		//	return new Rectangle(sq.Side, sq.Side);
		//}

	}

	public class Rectangle
	{
		public int Length { get; set; }
		public int Width { get; set; }

		private int _area;

		public int Area
		{
			get => _area;

			set { _area = Length * Width; }
		}

		public Rectangle(int length, int width)
		{
			Length = length;
			Width = width;
		}

	}

}
