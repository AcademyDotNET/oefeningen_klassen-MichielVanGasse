using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_eigen_huis
{
	class Kamer
	{
		//oppervlakte(in vierkante meter), een naam en prijs.Standaard is de prijs van een kamer 400euro
		public int Oppervlakte { get; set; }
		public string Naam { get; set; }
		public double Prijs { get; set; } = 400;
	}
}
