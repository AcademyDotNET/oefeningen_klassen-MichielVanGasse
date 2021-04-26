using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml_naar_code
{
	class Car
	{
		public Car(bool _engine, int pistonCount)
		{
			if (_engine)
			{
				Engine engine = new Engine(pistonCount);
			}
			CreateWheels();
		}
		void CreateWheels()
		{
			Wheel[] wheels = new Wheel[4];
			for (int i = 0; i < wheels.Length; i++)
			{
				wheels[i] = new Wheel();
			}
		}
	}
}
