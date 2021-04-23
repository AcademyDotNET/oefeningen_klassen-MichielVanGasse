using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figures
{
	class Rechthoek : GeometricFigure
	{
		public override int BerekenOppervlakte()
		{
			return Breedte * Hoogte;
		}
	}
}
