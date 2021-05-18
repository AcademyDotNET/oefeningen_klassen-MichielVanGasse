using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_simulator
{
	class Wedstrijd
	{
		public IAthlete Racer1 { get; set; }
		public IAthlete Racer2 { get; set; }
		public IAthlete BesteSpeler { get; set; }
		public IOutput Output { get; set; }
		public IRandom Rand { get; set; } 
		public Wedstrijd(IOutput output, IRandom rand)
		{
			Rand = rand;
			Output = output;
			Racer1 = new Wielrenner();
			Racer2 = new Wielrenner("jos", 13, true, false, Reeks.Amateur);

			SimuleerSpeler(Racer1);
			SimuleerSpeler(Racer2);

			SimuleerWedstrijd(Racer1, Racer2);

			BesteSpeler = new Wielrenner();
			BesteSpeler = FindBesteSpeler(Racer1, Racer2);
			BesteSpeler.Stayeren();
			BesteSpeler.Attack();
			BesteSpeler.Details();
		}
		void SimuleerSpeler(IAthlete testspeler)
		{
			for (int i = 0; i < 3; i++)
			{
				testspeler.Attack();
				testspeler.Stayeren();
			}
		}
		void SimuleerWedstrijd(IAthlete speler1, IAthlete speler2)
		{
			if (Rand.Next(0, 2) == 0)
			{
				Output.Log($"{speler1.SpelerNaam} wint.");
				speler1.Stayeren();
				speler1.Attack();
				speler1.Details();
			}
			else
			{
				Output.Log($"{speler2.SpelerNaam} wint.");
				speler2.Stayeren();
				speler2.Attack();
				speler2.Details();
			}
		}
		IAthlete FindBesteSpeler(IAthlete speler1, IAthlete speler2)
		{
			if (Rand.Next(0, 2) == 0)
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
