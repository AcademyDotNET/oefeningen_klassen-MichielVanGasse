using System;

namespace Figuren
{
	class Program
	{
		static void Main(string[] args)
		{
			Rechthoek rechthoek = new Rechthoek();
			Driehoek driehoek = new Driehoek();

			rechthoek.Breedte = 20;
			rechthoek.Lengte = 5;

			driehoek.Basis = 5;
			driehoek.Hoogte = 10;

			rechthoek.ToonOppervlakte();
			driehoek.ToonOppervlakte();
		}
	}
}
