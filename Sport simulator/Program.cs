using System;

namespace Sport_simulator
{
	class Program
	{
		static void Main(string[] args)
		{
			Wielrenner racer1 = new Wielrenner();
			Wielrenner racer2 = new Wielrenner();
			racer2.StelIn("jos", 13, true, false, Reeks.Amateur);

			SimuleerSpeler(racer1);
			SimuleerSpeler(racer2);

			SimuleerWedstrijd(racer1, racer2);

			Wielrenner besteSpeler = new Wielrenner(); 
			besteSpeler = BesteSpeler(racer1, racer2);
			besteSpeler.Stayeren();
			besteSpeler.Attack();
			besteSpeler.Details();
		}
		static void SimuleerSpeler(Wielrenner testspeler)
		{
			for (int i = 0; i < 3; i++)
			{
				testspeler.Attack();
				testspeler.Stayeren();
			}

		}
		static void SimuleerWedstrijd(Wielrenner speler1, Wielrenner speler2)
		{
			Random rand = new Random();
			if (rand.Next(0, 2) == 0)
			{
				Console.WriteLine($"{speler1.SpelerNaam} wint.");
				speler1.Stayeren();
				speler1.Attack();
				speler1.Details();
			}
			else
			{
				Console.WriteLine($"{speler2.SpelerNaam} wint.");
				speler2.Stayeren();
				speler2.Attack();
				speler2.Details();
			}
		}
		static Wielrenner BesteSpeler(Wielrenner speler1, Wielrenner speler2)
		{
			Random rand = new Random();
			if (rand.Next(0, 2) == 0)
			{
				return speler1;
			}
			else
			{
				return speler2;
			}
		}
	}
}
