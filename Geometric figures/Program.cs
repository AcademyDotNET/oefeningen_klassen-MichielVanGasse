using System;

namespace Geometric_figures
{
	class Program
	{
		static void Main(string[] args)
		{
			Driehoek driehoek = new Driehoek();
			Rechthoek rechthoek = new Rechthoek();
			Vierkant vierkant = new Vierkant(5);

			driehoek.Breedte = 10;
			driehoek.Hoogte = 5;
			rechthoek.Breedte = 10;
			rechthoek.Hoogte = 5;

			Console.WriteLine(driehoek.BerekenOppervlakte());
			Console.WriteLine(rechthoek.BerekenOppervlakte());
			Console.WriteLine(vierkant.BerekenOppervlakte());
		}
	}
}
