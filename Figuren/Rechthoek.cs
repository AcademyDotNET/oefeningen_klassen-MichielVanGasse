using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren
{
	class Rechthoek
	{
		private double lengte;
		private double breedte;

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
		public void ToonOppervlakte()
		{
			Console.WriteLine($"Oppervlakte rechthoek is {breedte * lengte}");
		}

	}
}
