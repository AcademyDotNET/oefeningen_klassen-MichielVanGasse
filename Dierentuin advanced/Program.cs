using System;
using System.Collections.Generic;

namespace Dierentuin_advanced
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Dier> dieren = new List<Dier>();
			bool run = true;
			do
			{
				do
				{
					run = true;
					Console.WriteLine("1 add hond\n2 add poes\nq stop adding");
					string choice = Console.ReadLine();

					if (choice == "1")
					{
						dieren.Add(new Hond());
						Console.WriteLine("hond toegevoegd");
					}
					if (choice == "2")
					{
						dieren.Add(new Poes());
						Console.WriteLine("poes toegevoegd");
					}
					if (choice == "q")
					{
						run = false;
					}
				} while (run);
				do
				{
					run = true;
					Console.WriteLine("1 Dier verwijderen\n2 Diergewicht gemiddelde\n3 Dier praten\n4 Opnieuw beginnen\n5 alle honden praten\n6 alle poezen praten");
					string choice = Console.ReadLine();

					if (choice == "1")
					{
						int input;
						bool wrong = true;
						do
						{

							if (Int32.TryParse(Console.ReadLine(), out input) && input - 1 < dieren.Count)
							{
								wrong = false;
							}
						} while (wrong);

						dieren.RemoveAt(input - 1);
						Console.WriteLine("dier verwijderd");
					}
					if (choice == "2")
					{
						int totalWeight = 0;
						for (int i = 0; i < dieren.Count; i++)
						{
							totalWeight += dieren[i].Weight;
						}
						Console.WriteLine($"totaal gewicht: {totalWeight}");
					}
					if (choice == "3")
					{
						for (int i = 0; i < dieren.Count; i++)
						{
							dieren[i].Zegt();
						}
					}
					if (choice == "4")
					{
						dieren.Clear();
						Console.Clear();
						run = false;
					}
					if (choice == "5")
					{
						for (int i = 0; i < dieren.Count; i++)
						{
							if (dieren[i] is Hond)
							{
								dieren[i].Zegt();
							}
						}
					}
					if (choice == "6")
					{
						for (int i = 0; i < dieren.Count; i++)
						{
							if (dieren[i] is Poes)
							{
								dieren[i].Zegt();
							}
						}
					}
				} while (run);
				run = true;
			} while (run);
		}
	}
}
