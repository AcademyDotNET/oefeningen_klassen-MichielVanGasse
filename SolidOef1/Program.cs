using System;
using System.Collections.Generic;

namespace SolidOef1
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Shape> lijst = new List<Shape>();
			OppBerekenaar oppBerekenaar = new OppBerekenaar(lijst);

			oppBerekenaar.VoegToe(new Square(5));
			oppBerekenaar.VoegToe(new Circle(10));

			Console.WriteLine(oppBerekenaar.Output()); 
		}
	}
}
