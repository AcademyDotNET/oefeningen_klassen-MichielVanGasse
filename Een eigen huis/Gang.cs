using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_eigen_huis
{
	class Gang : Kamer
	{
		public Gang(int oppervlakte)
		{
			Oppervlakte = oppervlakte;
			Prijs = 10 * Oppervlakte;
		}
	}
}
