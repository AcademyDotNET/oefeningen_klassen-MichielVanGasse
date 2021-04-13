using System;

namespace Sportspeler
{
	class Program
	{
		static void Main(string[] args)
		{
			Wielrenner rider1 = new Wielrenner();
			Wielrenner rider2 = new Wielrenner();
			Wielrenner rider3 = new Wielrenner();
			Wielrenner rider4 = new Wielrenner();

			rider1.StelIn("Tim Wellens", 5, false, true, Reeks.Pro);
			rider2.StelIn("Thomas De Gent", 69, true, true, Reeks.Pro);
			rider3.StelIn("Wout van Aert", 1337, false, false, Reeks.Pro);
			rider4.StelIn("Joske Vermeulen", 1, false, false, Reeks.Amateur);

			rider2.Attack();
			rider2.Details();
			rider3.Stayeren();
			rider3.Details();
			rider1.Stayeren();
		}
	}
}
