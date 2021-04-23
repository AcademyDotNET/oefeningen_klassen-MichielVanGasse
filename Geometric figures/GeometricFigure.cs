using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figures
{
	abstract class GeometricFigure
	{
		public int Hoogte { get; set; }
		public int Breedte  { get; set; }
		private int oppervlakte;

		public int Oppervlakte
		{
			get { return oppervlakte; }
			private set { oppervlakte = Hoogte * Breedte ; }
		}
		public abstract int BerekenOppervlakte();
	}
}
