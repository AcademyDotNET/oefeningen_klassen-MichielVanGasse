using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
	class EersteMinister : Minister
	{
		public override string ToString()
		{
			return $"{Naam} is de eerste minister";
		}
	}
}
