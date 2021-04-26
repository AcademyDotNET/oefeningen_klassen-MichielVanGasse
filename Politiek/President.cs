using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
	class President : Minister
	{
		public int Teller { get; private set; } = 4;
		public void JaarVerder()
		{
			Teller--;
		}
		public override string ToString()
		{
			return $"{Naam} is de president voor nog {Teller} jaar";
		}
	}
}
