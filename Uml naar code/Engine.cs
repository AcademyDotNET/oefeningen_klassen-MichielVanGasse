using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_naar_code
{
	class Engine
	{
		public Engine(int pistonCount)
		{
			CrankShaft crankShaft = new CrankShaft();
			CreatePistons(pistonCount);
		}
		void CreatePistons(int pistonCount)
		{
				Piston[] pistons = new Piston[pistonCount];
				for (int i = 0; i < pistons.Length; i++)
				{
					pistons[i] = new Piston();
				}
		}
	}
}
