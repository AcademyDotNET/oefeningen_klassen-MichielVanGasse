using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Het_dierenrijk
{
	class Mammal: Animal
	{
		public override void ToonInfo()
		{
			base.ToonInfo();
			Console.WriteLine("Maar ook een mammal.");
		}
		void DenkNa()
		{

		}
	}
}
