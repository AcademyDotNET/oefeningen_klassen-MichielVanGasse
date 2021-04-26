using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_naar_code
{
	class Boat
	{
		public Boat(bool _engine, int pistonCount)
		{
			if (_engine)
			{
				Engine engine = new Engine(pistonCount);
			}
			CreatePropellers();
		}
		void CreatePropellers()
		{
			Propeller[] propellers = new Propeller[4];
			for (int i = 0; i < propellers.Length; i++)
			{
				propellers[i] = new Propeller();
			}
		}
	}
}
