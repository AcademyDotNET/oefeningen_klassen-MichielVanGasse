using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_eigen_huis
{
	class Salon: Kamer
	{
		public bool HeeftSchouw { get; set; }
		public Salon(bool schouw)
		{
			HeeftSchouw = schouw;
			if (HeeftSchouw)
			{	
				Prijs = 500;
			}
			else
			{
				Prijs = 300;
			}
		}
	}
}
