using System;

namespace Een_eigen_huis
{
	class Program
	{
		static void Main(string[] args)
		{
			BadKamer badkamer = new BadKamer();
			Gang gang = new Gang(20);
			Salon salonSchouw = new Salon(true);
			Salon salonGeenSchouw = new Salon(true);
			
			Kamer[] KamersHuis1 = new Kamer[3] { gang,badkamer,salonSchouw };

			Huis huis1 = new Huis(KamersHuis1);

			Console.WriteLine(huis1.BerekenPrijs());
		}
	}
}
