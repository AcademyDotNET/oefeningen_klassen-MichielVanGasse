using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figures
{
	class Vierkant : Rechthoek
	{
		
		public Vierkant(int lengte,int breedte)
		{
			Breedte = lengte;
			Hoogte = lengte;
		}
		public Vierkant(int lengte)
		{
			Breedte = lengte;
			Hoogte = lengte;
		}
	}
}
