using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_with_interfaces
{
	class Rechthoek
	{
		private double lengte;
		private double breedte;
		public double Oppervlakte { get; set; }
		public double Lengte
		{
			get
			{
				return lengte;
			}
			set
			{
				if(value < 1)
				{
					lengte = 1;
				}
				else
				{
					lengte = value;
				}
			}
		}
		public double Breedte
		{
			get
			{
				return breedte;
			}
			set
			{
				breedte = value;
			}
		}
		public Rechthoek()
		{
			Oppervlakte = breedte * lengte;
		}
		public Rechthoek(int lengte, int breedte)
		{
			Breedte = breedte;
			Lengte = lengte;
			Oppervlakte = breedte * lengte;
		}
		public void ToonOppervlakte()
		{
			Oppervlakte = breedte * lengte;
			Console.WriteLine($"Oppervlakte rechthoek is {Oppervlakte}");
		}
		public static int VergelijkOppervlakte(Rechthoek rechthoek1, Rechthoek rechthoek2)
		{
			return rechthoek1.Oppervlakte.CompareTo(rechthoek2.Oppervlakte);
		}

	}
}
