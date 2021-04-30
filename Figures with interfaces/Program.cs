using System;
using System.Collections.Generic;

namespace Figures_with_interfaces
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Rechthoek> rechthoeken = new List<Rechthoek>();
			Random rand = new Random();
			for (int i = 0; i < 10; i++)
			{
				rechthoeken.Add(new Rechthoek(rand.Next(1, 20), rand.Next(1, 20)));
			}
						
			rechthoeken.Sort(Rechthoek.VergelijkOppervlakte);

			foreach (var rechthoek in rechthoeken)
			{
				Console.WriteLine(rechthoek.Oppervlakte);
			}
		}
	}
}
