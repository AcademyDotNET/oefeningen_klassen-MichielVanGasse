using System;
using System.Collections.Generic;

namespace SolidOef3
{
	public enum Kleuren
	{
		Geel,
		Groen,
		Blauw
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Product> productLijst = new List<Product>();

			productLijst.Add(new Product("Keyboard", Kleuren.Blauw, 10));
			productLijst.Add(new Product("Mice", Kleuren.Geel, 5));
			productLijst.Add(new Product("Screen", Kleuren.Groen, 35));

			//productLijst = Filter<Product>.FilterMethod(productLijst, "Kleur", kleur => (Kleuren)kleur == Kleuren.Groen);
			productLijst = Filter<Product>.FilterMethod(productLijst, "Grootte", grootte => (int)grootte < 10);

			PrintLijst(productLijst);
		}

		private static void PrintLijst(List<Product> productLijst)
		{
			foreach (var item in productLijst)
			{
				Console.WriteLine(item);
			}
		}
	}
}
