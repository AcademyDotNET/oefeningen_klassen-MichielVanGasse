using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_eigen_huis
{
	class Huis
	{
		Kamer[] kamers;
		public Huis(Kamer[] kamers)
		{
			this.kamers = kamers; 
		}
		public double BerekenPrijs()
		{
			double totaalPrijs = 0;
			for (int i = 0; i < kamers.Length; i++)
			{
				totaalPrijs += kamers[i].Prijs;
			}
			return totaalPrijs;
		}
	}
}
